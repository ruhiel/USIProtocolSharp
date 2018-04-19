using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USIProtocolSharp
{

    public class USIProtocol
    {
        public delegate void OnUSIOkEventHandler();

        private Process _Process;

        public event OnUSIOkEventHandler OnUSIOkEvent;

        public USIProtocol()
        {
            _Process = new Process();

            _Process.StartInfo.FileName = @"D:\ダウンロード\apery_sdt5\bin\apery_sdt5_bmi2.exe";

            _Process.StartInfo.UseShellExecute = false;
            _Process.StartInfo.RedirectStandardOutput = true; // 標準出力をリダイレクト
            _Process.StartInfo.RedirectStandardInput = true; // 標準入力をリダイレクト
            _Process.OutputDataReceived += new DataReceivedEventHandler(OnDataReceived);

            _Process.Start();
            _Process.BeginOutputReadLine();
        }

        public void USI() => _Process?.StandardInput.WriteLine("usi");

        public void Quit() => _Process.StandardInput.WriteLine("quit");

        // OutputDataReceivedイベントハンドラ. 行が出力されるたびに呼び出される
        private void OnDataReceived(object sender, DataReceivedEventArgs e)
        {
            Debug.WriteLine(e.Data);
            if(e.Data == "usiok")
            {
                OnUSIOkEvent?.Invoke();
            }
        }

        ~USIProtocol()
        {
            _Process?.Dispose();
        }
    }
}
