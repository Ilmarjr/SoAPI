namespace HosCad
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.mbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mbCpf = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExcluirPage = new System.Windows.Forms.Button();
            this.btnAtualizarPage = new System.Windows.Forms.Button();
            this.btnCadastrarPage = new System.Windows.Forms.Button();
            this.excluirPage1 = new HosCad.ExcluirPage();
            this.atualizarPage1 = new HosCad.AtualizarPage();
            this.atualizarPreviewPage1 = new HosCad.AtualizarPreviewPage();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(243, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(243, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(243, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(396, 165);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(537, 39);
            this.txtNome.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(396, 342);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(537, 39);
            this.txtEmail.TabIndex = 5;
            // 
            // mbTelefone
            // 
            this.mbTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbTelefone.Location = new System.Drawing.Point(396, 283);
            this.mbTelefone.Mask = "(00) 00000-0000";
            this.mbTelefone.Name = "mbTelefone";
            this.mbTelefone.Size = new System.Drawing.Size(537, 39);
            this.mbTelefone.TabIndex = 6;
            // 
            // mbCpf
            // 
            this.mbCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbCpf.Location = new System.Drawing.Point(396, 224);
            this.mbCpf.Mask = "000,000,000-00";
            this.mbCpf.Name = "mbCpf";
            this.mbCpf.Size = new System.Drawing.Size(537, 39);
            this.mbCpf.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(388, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(427, 46);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cadastro de Hóspede";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(22, 514);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(163, 37);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Sair";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(806, 413);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(127, 41);
            this.btnCadastrar.TabIndex = 10;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.btnExcluirPage);
            this.panel1.Controls.Add(this.btnAtualizarPage);
            this.panel1.Controls.Add(this.btnCadastrarPage);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 561);
            this.panel1.TabIndex = 13;
            // 
            // btnExcluirPage
            // 
            this.btnExcluirPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirPage.Location = new System.Drawing.Point(22, 260);
            this.btnExcluirPage.Name = "btnExcluirPage";
            this.btnExcluirPage.Size = new System.Drawing.Size(163, 62);
            this.btnExcluirPage.TabIndex = 13;
            this.btnExcluirPage.Text = "Excluir";
            this.btnExcluirPage.UseVisualStyleBackColor = true;
            this.btnExcluirPage.Click += new System.EventHandler(this.btnExcluirPage_Click);
            // 
            // btnAtualizarPage
            // 
            this.btnAtualizarPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarPage.Location = new System.Drawing.Point(22, 178);
            this.btnAtualizarPage.Name = "btnAtualizarPage";
            this.btnAtualizarPage.Size = new System.Drawing.Size(163, 62);
            this.btnAtualizarPage.TabIndex = 12;
            this.btnAtualizarPage.Text = "Atualizar";
            this.btnAtualizarPage.UseVisualStyleBackColor = true;
            this.btnAtualizarPage.Click += new System.EventHandler(this.btnAtualizarPage_Click);
            // 
            // btnCadastrarPage
            // 
            this.btnCadastrarPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarPage.Location = new System.Drawing.Point(22, 96);
            this.btnCadastrarPage.Name = "btnCadastrarPage";
            this.btnCadastrarPage.Size = new System.Drawing.Size(163, 62);
            this.btnCadastrarPage.TabIndex = 10;
            this.btnCadastrarPage.Text = "Cadastro";
            this.btnCadastrarPage.UseVisualStyleBackColor = true;
            this.btnCadastrarPage.Click += new System.EventHandler(this.btnCadastrarPage_Click);
            // 
            // excluirPage1
            // 
            this.excluirPage1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.excluirPage1.Location = new System.Drawing.Point(221, 2);
            this.excluirPage1.Name = "excluirPage1";
            this.excluirPage1.Size = new System.Drawing.Size(772, 561);
            this.excluirPage1.TabIndex = 15;
            // 
            // atualizarPage1
            // 
            this.atualizarPage1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.atualizarPage1.Location = new System.Drawing.Point(221, 2);
            this.atualizarPage1.Name = "atualizarPage1";
            this.atualizarPage1.Size = new System.Drawing.Size(770, 561);
            this.atualizarPage1.TabIndex = 14;
            // 
            // atualizarPreviewPage1
            // 
            this.atualizarPreviewPage1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.atualizarPreviewPage1.Location = new System.Drawing.Point(221, 2);
            this.atualizarPreviewPage1.Name = "atualizarPreviewPage1";
            this.atualizarPreviewPage1.Size = new System.Drawing.Size(770, 558);
            this.atualizarPreviewPage1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(988, 565);
            this.Controls.Add(this.atualizarPreviewPage1);
            this.Controls.Add(this.excluirPage1);
            this.Controls.Add(this.atualizarPage1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mbCpf);
            this.Controls.Add(this.mbTelefone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Hoscad";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox mbTelefone;
        private System.Windows.Forms.MaskedTextBox mbCpf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExcluirPage;
        private System.Windows.Forms.Button btnAtualizarPage;
        private System.Windows.Forms.Button btnCadastrarPage;
        private AtualizarPage atualizarPage;
        private AtualizarPage ExcluirPage;
        private AtualizarPage atualizarPage1;
        private ExcluirPage excluirPage1;
        private AtualizarPreviewPage atualizarPreviewPage1;
    }
}

