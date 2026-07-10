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

            Form1.File_XML = OFD.FileName
            Form1.ToolStripMenuItem_Save.Enabled = True

        End If

    End Sub

    Public Sub ReadXML(ByRef DS As DataSet)

        If System.IO.File.Exists(DataSetFile_Value) = True Then
            DS.Clear()
            DS.ReadXmlSchema(Replace(DataSetFile_Value, "xml", "xsd", 1, -1, CompareMethod.Text))
            DS.ReadXml(DataSetFile_Value, XmlReadMode.ReadSchema)
        End If

    End Sub

    Public Function ReadXML_Exists() As Boolean

        Dim ERRORList As New List(Of String) From {"Default"}

        If Directory.Exists(My.Settings.LastDirectory) = False Then ERRORList.Add("LastDirectory")
        If File.Exists(System.IO.Path.Combine(My.Settings.LastDirectory, My.Settings.LastFile)) = False Then ERRORList.Add("LastFile")
        If File.Exists(DataSetFile_Value) = False Then ERRORList.Add("DataSetFile")

        Dim FileName As String = String.Empty

        If ERRORList.Count = 1 Then

            Dim _File As String = Replace(DataSetFile_Value, ".xml", ".xsd")
            If File.Exists(_File) = False Then ERRORList.Add("DataSetFile_XSD")
            If ERRORList.Contains("DataSetFile_XSD") = True Then Return False

            Dim _DS As New DataSet
            _DS.ReadXmlSchema(_File)

            Dim DS As New DataSet
            DS = CL_DS.Get_DS(DS)

            For Each Table As DataTable In _DS.Tables
                If DS.Tables.Contains(Table.TableName) = False Then
                    ERRORList.Add("Tabelle fehlt: [" & Table.TableName & "]")
                Else
                    For Each Column As DataColumn In Table.Columns
                        If Table.Columns.Contains(Column.ColumnName) = False Then
                            ERRORList.Add("Spalte fehlt: [" & Table.TableName & "]" & Column.ColumnName)
                        End If
                    Next
                End If
            Next
        End If

        Dim ERRORString As String = "Fehlerhafte Dateien: " & vbCrLf
        For Each item In ERRORList
            If item <> "Default" Then ERRORString += item & vbCrLf
        Next

        If ERRORList.Count > 1 Then
            MessageBox.Show(ERRORString, "Fehlerhafte Dateien", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Return True

    End Function


End Class
