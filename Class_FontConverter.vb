Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Reflection
Imports System.Drawing

Public Class Class_FontConverter

    ' Liefert ein Dictionary aller öffentlichen Properties und ihrer Werte (TypeDescriptor)
    Public Function GetFontProperties(font As Font) As Dictionary(Of String, Object)
        Dim result As New Dictionary(Of String, Object)(StringComparer.OrdinalIgnoreCase)
        For Each pd As PropertyDescriptor In TypeDescriptor.GetProperties(font)
            Try
                Dim val = pd.GetValue(font)
                result(pd.Name) = val
            Catch ex As Exception
                result(pd.Name) = $"<Fehler: {ex.Message}>"
            End Try
        Next
        Return result
    End Function

    ' Gibt alle Properties (Name=Value) in Debug-Ausgabe aus
    Public Function FontToString(font As Font) As String
        Dim props = GetFontProperties(font)
        Dim Fontstring As String = String.Empty
        For Each kvp In props
            If Fontstring.Length > 0 Then Fontstring &= "|"
            Fontstring &= $"{If(kvp.Value, "Null")}"
        Next

        Return Fontstring
    End Function

    Public Function StringToFont(Fontstring As String) As Font

        Dim sp() As String = Split(Fontstring, "|", -1, CompareMethod.Text)

        Dim fd = CombineFontStyle(sp(1), sp(4), sp(7), sp(8))
        Dim unit As GraphicsUnit

        For Each wert In [Enum].GetValues(GetType(GraphicsUnit))
            If wert.ToString = sp(12) Then
                unit = wert
            End If
        Next
        Dim FontFamily = Replace(sp(0), "[FontFamily: Name=", "", 1, -1, CompareMethod.Text)
        FontFamily = Replace(FontFamily, "]", "", 1, -1, CompareMethod.Text)
        Dim font As New Font(FontFamily, sp(10), fd, unit, sp(2), sp(3))

        Return font
    End Function

    Public Function CombineFontStyle(bold As Boolean, italic As Boolean, strikeout As Boolean, underline As Boolean) As FontStyle
        Dim style As FontStyle = FontStyle.Regular
        If bold Then style = style Or FontStyle.Bold
        If italic Then style = style Or FontStyle.Italic
        If underline Then style = style Or FontStyle.Underline
        If strikeout Then style = style Or FontStyle.Strikeout
        Return style
    End Function
End Class

'0 FontFamily
'1 Bold
'2 GdiCharSet
'3 GdiVerticalFont
'4 Italic
'5 Name
'6 OriginalFontName 
'7 Strikeout
'8 Underline
'9 Style
'10 Size 
'11 SizeInPoints
'12 Unit 
'13 Height
'14 IsSystemFont
'15 SystemFontName 