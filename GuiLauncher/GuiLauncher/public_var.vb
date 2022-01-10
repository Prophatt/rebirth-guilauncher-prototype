Module public_var

    Public single_manifest = "Rebirth.xml"
    Public manifest_address = "https://join.cityofheroesrebirth.com/Manifests/Rebirth.xml"
    Public xml_path = System.AppDomain.CurrentDomain.BaseDirectory() + "manifests\Rebirth.xml"
    Public temp_xml_path = "manifests\temp_Rebirth.xml"
    Public _webclient As New System.Net.WebClient()


    Public launchparams As String
    Public order As String
    Public exe As String
    Public btnlaunch1 As String
    Public btnlaunch2 As String
    Public buttontxt As String

End Module
