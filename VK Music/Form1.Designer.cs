﻿namespace VK_Music
{
    partial class AuthorizationForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.AuthWebBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // AuthWebBrowser
            // 
            this.AuthWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AuthWebBrowser.Location = new System.Drawing.Point(0, 0);
            this.AuthWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.AuthWebBrowser.Name = "AuthWebBrowser";
            this.AuthWebBrowser.Size = new System.Drawing.Size(302, 236);
            this.AuthWebBrowser.TabIndex = 0;
            this.AuthWebBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.AuthWebBrowser_DocumentCompleted);
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 236);
            this.Controls.Add(this.AuthWebBrowser);
            this.Name = "AuthorizationForm";
            this.Text = "Authorization";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser AuthWebBrowser;
    }
}

