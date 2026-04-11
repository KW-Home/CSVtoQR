Public Class Class_XML

    Private DataSetFile_Value As String
    Public Property DataSetFile() As String
        Get
            Return DataSetFile_Value
        End Get
        Set(ByVal value As String)
            DataSetFile_Value = value
            My.Settings.MySavePath = value
            My.Settings.Save()
        End Set
    End Property

    Public Sub SaveXML(ByRef DS As DataSet)

        DS.WriteXml(DataSetFile_Value, XmlWriteMode.WriteSchema)
        DS.WriteXmlSchema(Replace(DataSetFile_Value, ".xml", ".xsd"))
        Form1.ToolStripStatusLabel_SaveFile.Text = DataSetFile_Value

    End Sub

    Public Sub OpenFileDialog_XML(ByRef DS As DataSet)

        Dim OFD As New OpenFileDialog
        With OFD
            .Title = "Datei Speichern (" & DataSetFile_Value & ")"
            .InitialDirectory = System.IO.Path.GetDirectoryName(DataSetFile_Value)
            .Filter = "XML-Dateien (*.xml)|*.xml|Alle Dateien (*.*)|*.*"
        End With

        If OFD.ShowDialog = DialogResult.OK Then
            DS = New DataSet
            DataSetFile = OFD.FileName
            ReadXML(DS)
        End If

    End Sub

    Public Sub ReadXML(ByRef DS As DataSet)
        If System.IO.File.Exists(DataSetFile_Value) Then
            DS.ReadXml(DataSetFile_Value, XmlReadMode.ReadSchema)
            'Form1.ToolStripStatusLabel_SaveFile.Text = DataSetFile_Value
        End If
    End Sub

End Class
