Imports System.IO

Public Class Class_File

    Private ReadOnly CL_DS As New Class_DS
    Private ReadOnly FRM As Form1

    Public Sub New(ByRef _FRM As Form1)

        FRM = _FRM

    End Sub

    'Public Event Changetext(sender, e)

    'Private File_XML_Value As String
    'Public Property File_XML() As String
    '    Get
    '        Return File_XML_Value
    '    End Get
    '    Set(ByVal value As String)
    '        If File_XML_Value <> value Then
    '            File_XML_Value = value
    '            RaiseEvent Changetext(Me, value)
    '        End If
    '    End Set
    'End Property

    Public Sub WriteXml(DS As DataSet, XMLFile As String)

        'Dim XMLFile As String = FRM.DataSet_Main.Tables("DT_File").Select("Relation='XML' AND RowID=0")(0)("File")

        If IsNothing(XMLFile) = True Then Return

        Dim XMLName As String = XMLFile

        XMLName = Replace(XMLName, ".xml", "", 1, -1, CompareMethod.Text)
        XMLName = Replace(XMLName, "xsd", "", 1, -1, CompareMethod.Text)


        If System.IO.File.Exists(XMLName & ".xsd") = True Then System.IO.File.Delete(XMLName & ".xsd")
        If System.IO.File.Exists(XMLName & ".xml") = True Then System.IO.File.Delete(XMLName & ".xml")

        DS.WriteXmlSchema(XMLName & ".xsd")
        DS.WriteXml(XMLName & ".xml", XmlWriteMode.IgnoreSchema)

    End Sub

    Public Sub OpenFileDialog_XML(ByRef DS As DataSet)

        Dim XMLFile As String = Form1.DataSet_Main.Tables("DT_File").Select("Relation='XML' AND RowID=0")(0)("File")

        Dim OFD As New OpenFileDialog
        With OFD
            .Title = "Datei Speichern (" & XMLFile & ")"
            .InitialDirectory = System.IO.Path.GetDirectoryName(path:=XMLFile)
            .Filter = "XML-Dateien (*.xml)|*.xml|Alle Dateien (*.*)|*.*"
        End With

        If OFD.ShowDialog = DialogResult.OK Then
            DS = New DataSet
            Form1.File_XML = OFD.FileName
            ReadXML(DS, OFD.FileName)

            Form1.File_XML = OFD.FileName
            Form1.ToolStripMenuItem_Save.Enabled = True

        End If

    End Sub

    Public Sub ReadXML(ByRef DS As DataSet, XMLFile As String)

        Dim XMLName As String = XMLFile
        XMLName = Replace(XMLName, "xml", "", 1, -1, CompareMethod.Text)
        XMLName = Replace(XMLName, "XSD", "", 1, -1, CompareMethod.Text)

        If System.IO.File.Exists(XMLName & ".xsd") = False Then Return
        If System.IO.File.Exists(XMLName & ".xml") = False Then Return

        DS.Clear()
        DS.ReadXmlSchema(XMLName & ".xsd")
        DS.ReadXml(XMLName & ".xml", XmlReadMode.ReadSchema)

    End Sub

    Public Function ReadXML_Exists() As Boolean

        Dim ERRORList As New List(Of String) From {"Default"}

        If Directory.Exists(My.Settings.LastDirectory) = False Then ERRORList.Add("LastDirectory")
        If File.Exists(System.IO.Path.Combine(My.Settings.LastDirectory, My.Settings.LastFile)) = False Then ERRORList.Add("LastFile")
        'If File.Exists(File_XML_Value) = False Then ERRORList.Add("File_XML")

        Dim FileName As String = String.Empty

        If ERRORList.Count = 1 Then
            Dim XML As String = Form1.File_XML
            Dim _File As String = Replace(XML, ".xml", ".xsd")
            If File.Exists(_File) = False Then ERRORList.Add("File_XML_XSD")
            If ERRORList.Contains("File_XML_XSD") = True Then Return False

            Dim _DS As New DataSet
            _DS.ReadXmlSchema(_File)

            Dim DS As New DataSet
            DS = CL_DS.Get_DS(DS, Form1.DataSet_Main)

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
