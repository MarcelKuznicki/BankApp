namespace BankApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2=new Label();
            button1=new Button();
            button2=new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Font=new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location=new Point(227, 29);
            label2.Name="label2";
            label2.Size=new Size(307, 45);
            label2.TabIndex=0;
            label2.Text="Witaj w Aurora Bank";
            // 
            // button1
            // 
            button1.AutoSize=true;
            button1.Font=new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location=new Point(138, 218);
            button1.Name="button1";
            button1.Size=new Size(123, 40);
            button1.TabIndex=1;
            button1.Text="Zaloguj się";
            button1.UseVisualStyleBackColor=true;
            button1.Click+=button1_Click;
            // 
            // button2
            // 
            button2.AutoSize=true;
            button2.Font=new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location=new Point(507, 218);
            button2.Name="button2";
            button2.Size=new Size(151, 40);
            button2.TabIndex=2;
            button2.Text="Zarejestruj się";
            button2.UseVisualStyleBackColor=true;
            button2.Click+=button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Name="Form1";
            Text="Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
    }
}