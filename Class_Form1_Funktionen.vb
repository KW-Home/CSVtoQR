Imports System.IO

Public Class Class_Form1_Funktionen

    Private ReadOnly FRM As Form1

    Public Function Check_Path(Value As String) As String

        ' 📁 Pfad zum Zielverzeichnis und der Datei definieren
        Dim SIP As String = Value

        '🤔 Überprüfen, ob das Verzeichnis existiert
        If Directory.Exists(SIP) = False Then
            '🛠️ Wenn nicht, Verzeichnis erstellen
            Dim MB_Text As String = "Der gesuchte Ordener" & vbNewLine & $"{SIP}{vbNewLine}existiert nicht!"
            Dim MB_Caption As String = "Ordner erstellen?"
            Dim MB_Button As MessageBoxButtons = MessageBoxButtons.YesNo
            Dim MB_ICO As MessageBoxIcon = MessageBoxIcon.Information
            If MessageBox.Show(MB_Text, MB_Caption, MB_Button, MB_ICO) = DialogResult.Yes Then
                Directory.CreateDirectory(SIP)
            End If
            Return SIP
        End If

        '🤔 Überprüfen, ob das Verzeichnis existiert
        'Dim SIN As String = Path.Combine(SIP, "Ausgabe.pdf")

        'Dim SIF As File = New(Path.Combine(SIP, SIN))

        '' Hier folgt der Code für die PDF-Erstellung...

        Return String.Empty

    End Function

End Class
