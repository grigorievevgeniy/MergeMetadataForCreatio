using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MergeMetadataForCreatio
{
    public partial class Form1 : Form
    {
        string prefix;

        public Form1()
        {
            InitializeComponent();

            //ToDo
            // Добавить подписи
            // Текстовое описание
            // Видео призентацию
        }

        private void btnMerge_Click(object sender, EventArgs e)
        {
            prefix = "Укажите здесь значение префикса!!!";

            string value1 = tbValue1.Text;
            var guids1 = GetGuids(value1);
            lblFirstValue.Text += " " + guids1.Count + " значений.";

            string value2 = tbValue2.Text;
            var guids2 = GetGuids(value2);
            lblSecondValue.Text += " " + guids2.Count + " значений.";

            var finishGuids = GetTotalList(guids1, guids2);

            tbResult.Text = ConvertGuidsToString(finishGuids);

            RefreshTextBoxes(guids1, guids2);
        }

        private void btnCopy_Click(object sender, EventArgs e) => Clipboard.SetText(tbResult.Text);

        private void RefreshTextBoxes(List<Guid> guids1, List<Guid> guids2)
        {
            tbValue1.Clear();
            tbValue1.AppendText(prefix + "[\n", Color.Blue);
            for (int i = 0; i < guids1.Count; i++)
            {
                if (guids2.Contains(guids1[i]))
                {
                    tbValue1.AppendText("\"" + guids1[i] + "\",", Color.Blue);
                    if (i == guids1.Count - 1)
                    {
                        tbValue1.AppendText(",", Color.Blue);
                    }
                }
                else
                {
                    tbValue1.AppendText("\"" + guids1[i] + "\"", Color.Red);
                    if (i == guids1.Count - 1)
                    {
                        tbValue1.AppendText(",", Color.Red);
                    }
                }

                if (i % 2 == 1 && i != guids1.Count - 1)
                {
                    tbValue1.AppendText("\n");
                }
            }
            tbValue1.AppendText("]", Color.Blue);

            tbValue2.Clear();
            tbValue2.AppendText(prefix + "[\n", Color.Blue);
            for (int i = 0; i < guids2.Count; i++)
            {
                if (guids1.Contains(guids2[i]))
                {
                    tbValue2.AppendText("\"" + guids2[i] + "\",", Color.Blue);
                    if (i == guids1.Count - 1)
                    {
                        tbValue1.AppendText(",", Color.Blue);
                    }
                }
                else
                {
                    tbValue2.AppendText("\"" + guids2[i] + "\",", Color.Red);
                    if (i == guids1.Count - 1)
                    {
                        tbValue1.AppendText(",", Color.Red);
                    }
                }

                //ToDo удалить последнюю запятую

                if (i % 2 == 1 && i != guids1.Count - 1)
                {
                    tbValue2.AppendText("\n");
                }
            }
            tbValue2.AppendText("]", Color.Blue);
        }

        #region Help Methods

        string ConvertGuidsToString(List<Guid> guids) => prefix + JsonConvert.SerializeObject(guids);

        List<Guid> GetTotalList(List<Guid> guids1, List<Guid> guids2)
        {
            List<Guid> totalList = new List<Guid>();

            foreach (var guid in guids1)
            {
                totalList.Add(guid);
            }


            foreach (var guid in guids2)
            {
                if (!totalList.Contains(guid))
                {
                    totalList.Add(guid);
                }
            }

            return totalList;
        }

        List<Guid> GetGuids(string str)
        {
            List<Guid> guids = new List<Guid>();

            if (str.StartsWith("~"))
            {
                var prefAndJson = str.Split('[');

                if (prefAndJson.Length == 2)
                {
                    prefix = prefAndJson[0];
                    str = '[' + prefAndJson[1];
                }
                else
                {
                    throw new Exception("Некорректные данные");
                }
            }

            guids = JsonConvert.DeserializeObject<List<Guid>>(str);

            return guids;
        }

        #endregion
    }
}
