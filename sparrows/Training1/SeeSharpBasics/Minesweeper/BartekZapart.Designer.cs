using System.Windows.Forms;
using SeeSharpBasics.Training3.Homework;
using SeeSharpBasics.Training4.minesweeper;

namespace Minesweeper
{
    partial class BartekZapart
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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Text = "BartekZapart";

            MineSweeper mnsw = new BartekZapartMineSweeper();

            var bombs = mnsw.BombsCount(10, 15, 15);

            //for

            //new Button()
        }

        #endregion
    }
}