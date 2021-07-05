
namespace Blocco_note
{
    partial class Home
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menu_file = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_nuovo = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_apriFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_salvaFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_salvaFilenome = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.barraDistato = new System.Windows.Forms.StatusStrip();
            this.status_primoPiano = new System.Windows.Forms.ToolStripStatusLabel();
            this.note = new System.Windows.Forms.RichTextBox();
            this.apri_file = new System.Windows.Forms.OpenFileDialog();
            this.salva_file = new System.Windows.Forms.SaveFileDialog();
            this.menu.SuspendLayout();
            this.barraDistato.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_file});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(800, 28);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // menu_file
            // 
            this.menu_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_nuovo,
            this.menu_apriFile,
            this.menu_salvaFile,
            this.menu_salvaFilenome,
            this.toolStripSeparator1,
            this.menu_exit});
            this.menu_file.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menu_file.Name = "menu_file";
            this.menu_file.Size = new System.Drawing.Size(46, 24);
            this.menu_file.Text = "File";
            // 
            // menu_nuovo
            // 
            this.menu_nuovo.Name = "menu_nuovo";
            this.menu_nuovo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menu_nuovo.Size = new System.Drawing.Size(224, 26);
            this.menu_nuovo.Text = "Nuovo file";
            this.menu_nuovo.Click += new System.EventHandler(this.menu_nuovo_Click);
            // 
            // menu_apriFile
            // 
            this.menu_apriFile.Name = "menu_apriFile";
            this.menu_apriFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F12)));
            this.menu_apriFile.Size = new System.Drawing.Size(224, 26);
            this.menu_apriFile.Text = "Apri file";
            this.menu_apriFile.Click += new System.EventHandler(this.menu_apriFile_Click);
            // 
            // menu_salvaFile
            // 
            this.menu_salvaFile.Name = "menu_salvaFile";
            this.menu_salvaFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menu_salvaFile.Size = new System.Drawing.Size(224, 26);
            this.menu_salvaFile.Text = "Salva file";
            this.menu_salvaFile.Click += new System.EventHandler(this.menu_salvaFile_Click);
            // 
            // menu_salvaFilenome
            // 
            this.menu_salvaFilenome.Name = "menu_salvaFilenome";
            this.menu_salvaFilenome.Size = new System.Drawing.Size(224, 26);
            this.menu_salvaFilenome.Text = "Salva file con nome";
            this.menu_salvaFilenome.Click += new System.EventHandler(this.menu_salvaFilenome_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // menu_exit
            // 
            this.menu_exit.Name = "menu_exit";
            this.menu_exit.Size = new System.Drawing.Size(224, 26);
            this.menu_exit.Text = "Esci dal notePier";
            this.menu_exit.Click += new System.EventHandler(this.menu_exit_Click);
            // 
            // barraDistato
            // 
            this.barraDistato.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.barraDistato.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.barraDistato.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status_primoPiano});
            this.barraDistato.Location = new System.Drawing.Point(0, 420);
            this.barraDistato.Name = "barraDistato";
            this.barraDistato.Size = new System.Drawing.Size(800, 30);
            this.barraDistato.TabIndex = 1;
            this.barraDistato.Text = "statusStrip1";
            // 
            // status_primoPiano
            // 
            this.status_primoPiano.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.status_primoPiano.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.status_primoPiano.Name = "status_primoPiano";
            this.status_primoPiano.Size = new System.Drawing.Size(137, 24);
            this.status_primoPiano.Text = "In primo piano: On";
            // 
            // note
            // 
            this.note.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.note.Dock = System.Windows.Forms.DockStyle.Fill;
            this.note.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.note.Location = new System.Drawing.Point(0, 28);
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(800, 392);
            this.note.TabIndex = 2;
            this.note.Text = "";
            // 
            // apri_file
            // 
            this.apri_file.DefaultExt = "txt";
            this.apri_file.Filter = "file TXT|*.txt|tutti i file|*.*";
            // 
            // salva_file
            // 
            this.salva_file.Filter = "file TXT|*.txt|tutti i file|*.*";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.note);
            this.Controls.Add(this.barraDistato);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "Home";
            this.Text = "NotePier!";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.barraDistato.ResumeLayout(false);
            this.barraDistato.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem menu_file;
        private System.Windows.Forms.ToolStripMenuItem menu_nuovo;
        private System.Windows.Forms.ToolStripMenuItem menu_apriFile;
        private System.Windows.Forms.ToolStripMenuItem menu_salvaFile;
        private System.Windows.Forms.ToolStripMenuItem menu_salvaFilenome;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menu_exit;
        private System.Windows.Forms.StatusStrip barraDistato;
        private System.Windows.Forms.RichTextBox note;
        private System.Windows.Forms.ToolStripStatusLabel status_primoPiano;
        private System.Windows.Forms.OpenFileDialog apri_file;
        private System.Windows.Forms.SaveFileDialog salva_file;
    }
}

