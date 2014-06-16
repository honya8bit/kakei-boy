using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


/* 構想としては各月ごとにテーブルを区切る。
 * テーブル名はkakeibo201404等
 */

namespace kakei_boy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updateData();
        }

        private void btnInsertRecord_Click(object sender, EventArgs e)
        {
           
        }

        /// <summary>
        /// 表示の書き換え
        /// </summary>
        private void updateData()
        {
            /* データベースからdgvへ読み込み */
            try
            {
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = "Host=localhost;user id=kamimura;password=kamimura;database=kakeiboy";
                MySqlCommand com = new MySqlCommand("select * from data;", conn);
                conn.Open();
                MySqlDataReader reader = com.ExecuteReader();

                string[] names = new string[reader.FieldCount];
                for (int i = 0; i < reader.FieldCount; i++)
                    names[i] = reader.GetName(i);

                // readでレコードを進めてvalueカラムを読む
                // メモ：readerはカーソル
                while (reader.Read())
                {
                    MessageBox.Show(reader.GetInt32("value").ToString());
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                ;
            }
            
            
        }

    }
}