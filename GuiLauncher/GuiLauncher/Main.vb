Imports System.Xml
Imports System.Net.WebClient
Imports System.Security.Cryptography
Imports System.Text
Imports System.IO

Public Class Main
    'Prototyped City of Heroes Specific web browser to explore feasibilty of a branded launcher
    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Visible = False
        'xml_info.Show()
        load_wait.Show()
        getmanifests()


        Me.Visible = True

        If Me.Visible = True Then
            load_wait.Close()

        End If
    End Sub

    Private Sub getmanifests()
        'check for manifest folder/manifest and download if not existing
        If My.Computer.FileSystem.DirectoryExists(System.AppDomain.CurrentDomain.BaseDirectory() + "manifests") = False Then

            My.Computer.FileSystem.CreateDirectory(System.AppDomain.CurrentDomain.BaseDirectory() + "manifests")
            Try
                load_wait.Text = "Downloading Manifest."
                _webclient.DownloadFile(manifest_address, xml_path)
            Catch _exception As Exception
                MessageBox.Show("Exception caught in process: {0}", _exception.ToString())
            End Try
            'go and download files from server
            getfiles()
            'show hide buttons based on launch options in manifest
            getlauncher()
        Else
            'download manifest copy
            gettempmanifest()
            'see if md5 hash is the same as current manifest, if not delete and rename temp file and download files
            comparemanifest()
            'populate launcher buttons
            getlauncher()
        End If


    End Sub

    Private Sub getfiles()

        'download files from server
        Dim usemanifest As String = xml_path
        'MessageBox.Show(usemanifest)
        Dim document As XmlReader = New XmlTextReader(usemanifest)

        While (document.Read())

            Dim type = document.NodeType

            If (type = XmlNodeType.Element) Then
                If document.Name = "file" Then
                    'for some reason the xml info would not stay in the global variables,
                    'so pushing them out to xml_info which stays hidden and only holds info
                    Dim filename As String = document.GetAttribute("name").ToString
                    filename = filename.Replace("/", "\")
                    Dim fileloc As String = System.AppDomain.CurrentDomain.BaseDirectory() + filename
                    xml_info.locfile_txtbx.Text = fileloc
                    Dim Md5hash = document.GetAttribute("md5").ToString
                    xml_info.md5_hash_txtbx.Text = Md5hash
                    Dim filesize = document.GetAttribute("size").ToString
                    xml_info.filesize_txtbx.Text = filesize


                    If filename.Contains("\") = True Then
                        filename = filename.Replace("/", "\")
                        Dim filesplit As String() = filename.Split("\")
                        Dim localfolder As String = filesplit(0).ToString()
                        xml_info.localfolder_txtbx.Text = localfolder
                        Dim localfile As String = filesplit(1).ToString()
                        xml_info.filename_txtbx.Text = localfile

                    Else
                        Dim localfile As String = filename
                        xml_info.filename_txtbx.Text = localfile

                    End If
                End If
                'delete any files marked as 0 size in manifest
                If (xml_info.filesize_txtbx.Text = "0") Then
                    If My.Computer.FileSystem.FileExists(xml_info.locfile_txtbx.Text) = True Then
                        My.Computer.FileSystem.DeleteFile(xml_info.locfile_txtbx.Text)
                    End If
                Else
                    'get url info and put in xml_info, then download files
                    If document.Name = "url" Then
                        Dim webloc As String = document.ReadInnerXml.ToString()
                        xml_info.webloc_txtbx.Text = webloc
                        'at this point everything needed to begin parsing is in the xml_info box
                        'MessageBox.Show(xml_info.filename_txtbx.Text)
                        'if local file does not exist, download, check folder first and if no folder create folder
                        If My.Computer.FileSystem.FileExists(xml_info.locfile_txtbx.Text) = False Then
                            If xml_info.localfolder_txtbx.Text <> "" Then
                                My.Computer.FileSystem.CreateDirectory(System.AppDomain.CurrentDomain.BaseDirectory() + xml_info.localfolder_txtbx.Text)
                                Try
                                    load_wait.Text = "Downloading File...  " + xml_info.filename_txtbx.Text
                                    _webclient.DownloadFile(xml_info.webloc_txtbx.Text, xml_info.locfile_txtbx.Text)
                                Catch
                                End Try
                            Else
                                load_wait.Text = "Downloading File...  " + xml_info.filename_txtbx.Text
                                _webclient.DownloadFile(xml_info.webloc_txtbx.Text, xml_info.locfile_txtbx.Text)
                            End If
                        Else
                            'do the md5 hash compare
                            Dim oghash() As Byte = System.IO.File.ReadAllBytes(xml_info.locfile_txtbx.Text)
                            Dim Md5 As New MD5CryptoServiceProvider()

                            Dim bytehash() As Byte = Md5.ComputeHash(oghash)

                            Dim sBuilder As New StringBuilder()
                            'build hash string
                            For n As Integer = 0 To bytehash.Length - 1
                                sBuilder.Append(bytehash(n).ToString("X2"))
                            Next n
                            Dim localhash As String = sBuilder.ToString()
                            'clear hash strings in preparation for the next file
                            sBuilder.Clear()
                            Array.Clear(bytehash, 0, bytehash.Length)
                            'compare local hash to manifest hash, if different delete and download new file
                            If localhash <> xml_info.md5_hash_txtbx.Text Then
                                load_wait.Text = "The MD5 of the local file doesn't match the server. Redownloading file...   " + xml_info.filename_txtbx.Text
                                My.Computer.FileSystem.DeleteFile(xml_info.locfile_txtbx.Text)
                                Try
                                    _webclient.DownloadFile(xml_info.webloc_txtbx.Text, xml_info.locfile_txtbx.Text)
                                Catch
                                End Try
                            End If

                        End If





                        ' load_wait.Text = "Downloading File...  " + xml_info.filename_txtbx.Text
                        '_webclient.DownloadFile(xml_info.webloc_txtbx.Text, xml_info.locfile_txtbx.Text)
                    End If

                    End If


            End If

        End While


        document.Close()
        getlauncher()
    End Sub

    Private Sub gettempmanifest()
        'download temp manifest, do this at launch or when validating files
        load_wait.Text = "Comparing Local Manifest to Server Manifest"
        Try
            _webclient.DownloadFile(manifest_address, temp_xml_path)
        Catch _exception As Exception
            MessageBox.Show("Exception caught in process: {0}", _exception.ToString())
        End Try
    End Sub

    Private Sub comparemanifest()
        'compare temp manifest to local manifest  hash
        'the actual hash generation should really be condensed into one function
        Dim oghash() As Byte = System.IO.File.ReadAllBytes(xml_path)
        Dim temphash() As Byte = System.IO.File.ReadAllBytes(temp_xml_path)

        Dim Md5 As New MD5CryptoServiceProvider()

        Dim bytehash() As Byte = Md5.ComputeHash(oghash)

        Dim sBuilder As New StringBuilder()
        'build hash string
        For n As Integer = 0 To bytehash.Length - 1
            sBuilder.Append(bytehash(n).ToString("X2"))
        Next n

        Dim localhash As String = sBuilder.ToString()
        'clear hash string in case files get downloaded
        sBuilder.Clear()
        Array.Clear(bytehash, 0, bytehash.Length)

        bytehash = Md5.ComputeHash(temphash)

        For n As Integer = 0 To bytehash.Length - 1
            sBuilder.Append(bytehash(n).ToString("X2"))
        Next n
        Dim serverhash As String = sBuilder.ToString()


        sBuilder.Clear()
        Array.Clear(bytehash, 0, bytehash.Length)


        'MessageBox.Show(localhash)
        'MessageBox.Show(serverhash)

        'compare hash, if different then delete original and rename temp file
        If localhash <> serverhash Then
            load_wait.Text = "The MD5 of the manifest doesn't match the server. Verifying Files."
            My.Computer.FileSystem.DeleteFile(xml_path)
            My.Computer.FileSystem.RenameFile(temp_xml_path, "Rebirth.xml")
            getfiles()
        Else
            load_wait.Text = "The MD5 matches. No additional download needed"
            My.Computer.FileSystem.DeleteFile(temp_xml_path)
        End If


    End Sub

    Private Sub getlauncher()
        'show/hide launcher buttons depending on launch options in manifest
        Dim ogmanifest As String = xml_path
        Dim document As XmlReader = New XmlTextReader(ogmanifest)

        While (document.Read())

            Dim type = document.NodeType
            If (type = XmlNodeType.Element) Then
                If document.Name = "launch" Then
                    launchparams = document.GetAttribute("params").ToString
                    order = document.GetAttribute("order").ToString
                    exe = document.GetAttribute("exec").ToString
                    buttontxt = document.ReadInnerXml.ToString()
                    If (order = 0) Then
                        btnlaunch1 = exe + " " + launchparams
                        launchbtn1.Visible = True
                        launchbtn1.Text = buttontxt
                        'MessageBox.Show(btnlaunch1)
                    End If
                    If (order = 1) Then
                        btnlaunch2 = exe + " " + launchparams
                        launchbtn2.Visible = True
                        launchbtn2.Text = buttontxt
                        'MessageBox.Show(btnlaunch2)
                    End If
                End If
            End If
        End While
        document.Close()
        'push webpage from manifest to webcontrol box
        getwebpage()

    End Sub

    Private Sub exitbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitbtn.Click
        End
    End Sub

    Private Sub verifybtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verifybtn.Click
        'handles file verification on demand
        Me.Visible = False

        load_wait.Show()
        load_wait.Text = "Beginning Validation."
        getfiles()

        Me.Visible = True

        If Me.Visible = True Then
            load_wait.Close()

        End If
    End Sub

    Private Sub launchbtn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles launchbtn1.Click
        'launch button control to start up commandline
        If console_chxbx.Checked = True Then
            Process.Start("CMD", "/C " & btnlaunch1 & " -console")
        Else
            Process.Start("CMD", "/C " & btnlaunch1)
        End If
    End Sub

    Private Sub launchbtn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles launchbtn2.Click
        'launch button control to start up commandline
        If console_chxbx.Checked = True Then
            Process.Start("CMD", "/C " & btnlaunch2 & " -console")
        Else
            Process.Start("CMD", "/C " & btnlaunch2)
        End If
    End Sub

    Private Sub getwebpage()
        'handles pushing the webpage to the web control
        Dim ogmanifest As String = xml_path
        Dim document As XmlReader = New XmlTextReader(ogmanifest)

        While (document.Read())

            Dim type = document.NodeType
            If (type = XmlNodeType.Element) Then
                If document.Name = "poster_image" Then
                    Dim imageaddress As String = document.GetAttribute("url").ToString
                    rebirth_splash_browser.Navigate(imageaddress)
                End If

            End If

        End While
        document.Close()
    End Sub
End Class
