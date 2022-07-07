using ClosedXML.Excel;
using RubikCubeTimer.Entities.DBConnection;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RubikCubeTimer.Entities
{
    class Relatorio 
    {
        public static void ExportReport(Usuario usuario)
        {
            SqlConnection conexao = DBConnectionString.GetConnectionString();
            conexao.Open();
            SqlCommand comando = new SqlCommand();

            XLWorkbook wb = new XLWorkbook();

            IXLWorksheet records = wb.Worksheets.Add("My best times");
            IXLWorksheet averages = wb.Worksheets.Add("My best averages of 5");

            #region Preenche a aba "My information"
            IXLWorksheet myInfo = wb.Worksheets.Add("My information");
            myInfo.Column(1).Width = 1;
            myInfo.Column(2).Width = 8;
            myInfo.Column(3).Width = 25;
            myInfo.Column(4).Width = 44;
            myInfo.SheetView.Worksheet.ShowGridLines = false;
            myInfo.Range("B1:D1").Merge();
            myInfo.Cell(1, 2).Value = "MY INFORMATION";
            myInfo.Cell(1, 2).Style.Font.Bold = true;
            myInfo.Cell(1, 2).Style.Font.FontSize = 24;
            myInfo.Cell(1, 2).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            myInfo.Range("B2:D2").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;
            myInfo.Range("B3:D3").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;
            myInfo.Range("B4:D4").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;

            //Header
            myInfo.Cell(2, 2).Value = "ID";
            myInfo.Cell(2, 3).Value = "USERNAME";
            myInfo.Cell(2, 4).Value = "NAME";
            myInfo.Range("B2:D2").Style.Fill.BackgroundColor = XLColor.DarkPowderBlue;
            myInfo.Range("B2:D2").Style.Font.Bold = true;
            myInfo.Range("B2:D2").Style.Font.FontColor = XLColor.White;

            //Body
            myInfo.Cell(3, 2).Value = usuario.Id.ToString();
            myInfo.Cell(3, 3).Value = usuario.Login;
            myInfo.Cell(3, 4).Value = usuario.Nome;

            myInfo.Range("B2:D2").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            myInfo.Range("B2:D2").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            myInfo.Range("B2:D2").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            myInfo.Range("B2:D2").Style.Border.RightBorder = XLBorderStyleValues.Thin;

            myInfo.Range("B3:D3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            myInfo.Range("B3:D3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            myInfo.Range("B3:D3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            myInfo.Range("B3:D3").Style.Border.RightBorder = XLBorderStyleValues.Thin;
            #endregion

            #region Configura Worksheet records
            records.Column(1).Width = 1;
            records.Column(2).Width = 12;
            records.Column(3).Width = 14;
            records.Column(4).Width = 14;
            records.SheetView.Worksheet.ShowGridLines = false;
            records.Range("B1:D1").Merge();
            records.Cell(1, 2).Value = "MY BEST TIMES";
            records.Cell(1, 2).Style.Font.Bold = true;
            records.Cell(1, 2).Style.Font.FontSize = 24;
            records.Cell(1, 2).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

            //Header
            records.Cell(2, 2).Value = "CUBE TYPE";
            records.Cell(2, 3).Value = "BEST TIMES";
            records.Cell(2, 4).Value = "DATE";
            records.Range("B2:D2").Style.Fill.BackgroundColor = XLColor.SmaltDarkPowderBlue;
            records.Range("B2:D2").Style.Font.Bold = true;
            records.Range("B2:D2").Style.Font.FontColor = XLColor.White;

            records.Range("B2:D2").SetAutoFilter();
            #endregion

            #region Comando para obteção de records
            comando.Connection = conexao;
            comando.CommandText = "Select RECORD.TIPO_CUBO, RECORD.MELHOR_TEMPO, RECORD.DATA_REC " +
                "from RECORD inner join USUARIO ON RECORD.ID_US = USUARIO.ID_US " +
                "where RECORD.ID_US = @id " +
                "group by RECORD.TIPO_CUBO, RECORD.MELHOR_TEMPO, RECORD.DATA_REC";
            comando.Parameters.Add("@id", SqlDbType.Int).Value = usuario.Id;

            SqlDataReader reader = comando.ExecuteReader();            

            int i = 3;
            while (reader.Read())
            {
                string tipoCubo = SetTipoCuboName((int)reader[0]);            

                records.Cell(i, 2).Value = tipoCubo;
                records.Cell(i, 3).Value = reader[1].ToString();
                records.Cell(i, 4).Value = reader[2].ToString();

                records.Range($"B{i}:D{i}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;
                records.Range($"B{i}:D{i}").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                records.Range($"B{i}:D{i}").Style.Border.TopBorder = XLBorderStyleValues.Thin;
                records.Range($"B{i}:D{i}").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                records.Range($"B{i}:D{i}").Style.Border.RightBorder = XLBorderStyleValues.Thin;
                i++;
            }
            #endregion            

            conexao.Close();
            conexao.Open();

            #region Configura Worksheet averages
            averages.Column(1).Width = 1;
            averages.Column(2).Width = 12;
            averages.Column(3).Width = 22;
            averages.Column(4).Width = 14;
            averages.SheetView.Worksheet.ShowGridLines = false;
            averages.Range("B1:D1").Merge();
            averages.Cell(1, 2).Value = "MY BEST AVERAGES OF 5";
            averages.Cell(1, 2).Style.Font.Bold = true;
            averages.Cell(1, 2).Style.Font.FontSize = 24;
            averages.Cell(1, 2).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

            //Header
            averages.Cell(2, 2).Value = "CUBE TYPE";
            averages.Cell(2, 3).Value = "BEST AVERAGES OF 5";
            averages.Cell(2, 4).Value = "DATE";
            averages.Range("B2:D2").Style.Fill.BackgroundColor = XLColor.SmaltDarkPowderBlue;
            averages.Range("B2:D2").Style.Font.Bold = true;
            averages.Range("B2:D2").Style.Font.FontColor = XLColor.White;

            averages.Range("B2:D2").SetAutoFilter();

            #endregion

            #region Comando para obtenção de médias
            comando.CommandText = "Select MEDIA_DE_CINCO.TIPO_CUBO, MEDIA_DE_CINCO.MELHOR_MEDIA, MEDIA_DE_CINCO.DATA_MEDIA5 " +
                "from MEDIA_DE_CINCO inner join USUARIO ON MEDIA_DE_CINCO.ID_US = USUARIO.ID_US " +
                "where MEDIA_DE_CINCO.ID_US = @idAv " +
                "group by MEDIA_DE_CINCO.TIPO_CUBO, MEDIA_DE_CINCO.MELHOR_MEDIA, MEDIA_DE_CINCO.DATA_MEDIA5";
            comando.Parameters.Add("@idAv ", SqlDbType.Int).Value = usuario.Id;

            reader = comando.ExecuteReader();

            i = 3;
            while (reader.Read())
            {
                string tipoCubo = SetTipoCuboName((int)reader[0]);

                averages.Cell(i, 2).Value = tipoCubo;
                averages.Cell(i, 3).Value = reader[1].ToString();
                averages.Cell(i, 4).Value = reader[2].ToString();

                averages.Range($"B{i}:D{i}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;
                averages.Range($"B{i}:D{i}").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                averages.Range($"B{i}:D{i}").Style.Border.TopBorder = XLBorderStyleValues.Thin;
                averages.Range($"B{i}:D{i}").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                averages.Range($"B{i}:D{i}").Style.Border.RightBorder = XLBorderStyleValues.Thin;
                i++;
            }

            #endregion


            conexao.Close();
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "Excel Workbook|*.xlsx";
            fileDialog.FileName = $"{usuario.Login}_records.xlsx";

            try
            {
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    wb.SaveAs(fileDialog.FileName);

                    MessageBox.Show("Your records were exported to an excel file successfully!",
                        "Rubik's Cube Timer");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Rubik's Cube Timer");
            }

        }

        private static string SetTipoCuboName(int tipoCubo)
        {
            if (tipoCubo == 2)
            {
                return "2x2";
            }
            else if (tipoCubo == 3)
            {
                return "3x3";
            }
            else if (tipoCubo == 4)
            {
                return "4x4";
            }
            else if (tipoCubo == 5)
            {
                return  "5x5";
            }
            else if (tipoCubo == 6)
            {
                return  "Megaminx";
            }
            else if (tipoCubo == 7)
            {
                return "Pyraminx";
            }
            else if (tipoCubo == 8)
            {
                return "Mirror Blocks";
            }
            else
            {
                return "All";
            }
        }

    }
}
