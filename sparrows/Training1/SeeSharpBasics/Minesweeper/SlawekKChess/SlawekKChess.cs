using System;
using System.Drawing;
using System.Windows.Forms;
using SeeSharpBasics.SlawekKowal.Training5;
using SeeSharpBasics.Training5.Chess;

namespace Minesweeper.SlawekKChess
{
    public partial class SlawekKChess : Form
    {
        private readonly ChessBoard _chessBoard = new ChessBoard();

        private bool _player;
        private ChessField _sField = null;
        private ChessField _dField = null;
        ChessSteering game = new ChessSteering();
        private bool Player
        {
            get { return _player; }
            set
            {
                _player = value;
                button1.BackColor = _player ? Color.White : Color.Black;
            }
        }


        

        public SlawekKChess()
        {
            InitializeComponent();
        }



        private void SlawekKChess_Load(object sender, EventArgs e)
        {
            foreach (var chessField in _chessBoard.Chess)
            {
                chessField.Click += Clicker;
            }

            game.ChessLoad(_chessBoard);
            game.ButtonSetup(this, _chessBoard);
            game.ButtonImageLoad(_chessBoard);
            Player = true;
            game.ChessFieldEnabled(Player, _chessBoard);

        }

        private void Clicker(object sender, EventArgs e)
        {
            var helpBtn = (ChessField)sender;
            if (_sField == helpBtn)
            {
                game.ChessFieldEnabled(Player, _chessBoard);
                game.ChessFieldColorBack(_chessBoard);
                _sField = null;
                return;
            }

            if (_sField != null)
            {
                _dField = helpBtn;
                _sField.Figure.Move(_sField.X - 1, _sField.Y - 1, _dField.X - 1, _dField.Y - 1, _chessBoard);
                Player = !Player;
                game.ChessFieldEnabled(Player, _chessBoard);
                game.ChessFieldColorBack(_chessBoard);
                _sField = null;
                _dField = null;
                return;
            }

            if (_sField == null) _sField = helpBtn;
            _sField.BackColor = Color.BlueViolet;
            var xx = helpBtn.Figure.GetType().Name;
            game.ChessFieldEnabled(_chessBoard);

            game.ChessFieldEnabled(helpBtn, _chessBoard);
            switch (xx)
            {

                case "Bishop":
                    SlawekKowalMove.CanMoveDiagonally(helpBtn, _chessBoard);
                    break;
                case "Pawn":
                    SlawekKowalMove.MovePawn(helpBtn, _chessBoard);
                    break;
                case "Knight":
                    SlawekKowalMove.MoveKnight(helpBtn, _chessBoard);
                    break;
                case "Queen":
                    SlawekKowalMove.CanMoveVerHor(helpBtn, _chessBoard);
                    SlawekKowalMove.CanMoveDiagonally(helpBtn, _chessBoard);
                    break;
                case "King":
                    SlawekKowalMove.MoveKing(helpBtn, _chessBoard);
                    break;
                case "Rook":
                    SlawekKowalMove.CanMoveVerHor(helpBtn, _chessBoard);
                    break;
            }
            game.ChessFieldColor(helpBtn, _chessBoard);

        }


    }
}
