using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MergeMetadataForCreatio
{
    public partial class Form1 : Form
    {
        string prefix;

        public Form1()
        {
            InitializeComponent();
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
        }

        #region Help Methods

        string ConvertGuidsToString(List<Guid> guids) => prefix + JsonConvert.SerializeObject(guids);

        List<Guid> GetTotalList(List<Guid> guids1, List<Guid> guids2)
        {
            List<Guid> totalList = guids1;

            foreach (var guid in guids2)
            {
                if (!totalList.Contains(guid))
                {
                    totalList.Add(guid);
                    Console.WriteLine(guid);
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
