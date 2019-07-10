using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace NetworkSimulator
{
    public partial class FormServer : Form
    {
        // サーバソケット制御オブジェクト
        private NetworkServer _server;

        public FormServer()
        {
            InitializeComponent();
        }

        // 他クラスからのリッチテキストボックス（情報）への文字列追加べメソッド
        public void AddText_Information(string strText)
        {
            this.richTexBox_Information.AppendText(strText);
        }
        // 他クラスからのリッチテキストボックス（データ）への文字列追加べメソッド
        public void AddText_Data(string strText)
        {
            this.richTexBox_Data.AppendText(strText);
        }

        // Listen & Accept ボタンクリックハンドラ
        private async void Server_Listen_Accept_Click(object sender, EventArgs e)
        {
            // 接続待ちエンドポイントインスタンス作成
            var _endpoint = new IPEndPoint(IPAddress.Loopback, 50000);

            // サーバの作成
            _server = new NetworkServer(_endpoint);

            this.richTexBox_Information.AppendText("Start server listening.\n");

            // Listen & Accept Start
            int result = await _server.Listen();

            // Check result
            if (Constants.RESULT_SUCCESS == result)
            {
                this.richTexBox_Information.AppendText("Connection established.\n");
            }
            else
            {
                this.richTexBox_Information.AppendText("Connection not established.\n");
            }
        }

        // サーバソケット制御クラス
        public class NetworkServer
        {
            private readonly IPEndPoint m_IPEndPoint;  //接続待ちするエンドポイント
            private readonly TcpListener m_TcpListener; //TCP Listener
            private TcpClient m_TcpClient;                    // 接続済みコネクション

            //コンストラクタ
            public NetworkServer(IPEndPoint iPEndPoint)
            {
                // 指定されたエンドポイントでTCP Listener を準備
                m_IPEndPoint = iPEndPoint;
                m_TcpListener = new TcpListener(m_IPEndPoint);
            }

            //Listen処理を非同期処理として実装（戻り値は、Taskクラス）
            public async Task<int> Listen()
            {
                int iRet = Constants.RESULT_NOT_SUCCESS;

                m_TcpListener.Start();   // Listen()スタート

                // 接続要求受取り処理の完了を待つ
                m_TcpClient = await m_TcpListener.AcceptTcpClientAsync();

                // ソケットが接続済みであれば成功を返す
                if (m_TcpClient.Connected) iRet = Constants.RESULT_SUCCESS;
                return iRet;
            }
        }
    }
}
