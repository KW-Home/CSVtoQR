Imports System.IO

Public Class Class_XML

    Private ReadOnly CL_DS As New Class_DS

    Public Event Changetext(sender, e)

    Private DataSetFile_Value As String
    Public Property DataSetFile() As String
        Get
            Return DataSetFile_Value
        End Get
        Set(ByVal value As String)
            If DataSetFile_Value <> value Then
                DataSetFile_Value = value
                RaiseEvent Changetext(Me, value)
            End If
        End Set
    End Property

    Public Sub SaveXML(ByRef DS As DataSet)

        If IsNothing(DataSetFile_Value) = False Then
            DS.WriteXml(DataSetFile_Value, XmlWriteMode.IgnoreSchema)
            DS.WriteXmlSchema(Replace(DataSetFile_Value, ".xml", ".xsd"))
        Else
            MessageBox.Show("Kein Pfad vorhanden")
        End If

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
            DS.Clear()
            DS.ReadXmlSchema(Replace(DataSetFile_Value, "xml", "xsd", 1, -1, CompareMethod.Text))
            DS.ReadXml(DataSetFile_Value, XmlReadMode.ReadSchema)
        End If
    End Sub

End Class
