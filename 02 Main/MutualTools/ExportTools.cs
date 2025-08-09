using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using Rex.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MutualTools
{
    public class ExportTools
    {
        /// <summary>
        /// Excel格式统计总的数据导出（重载1）
        /// </summary>
        /// <param name="isExport">数据导出标志位-限制必须先查询再导出</param>
        /// <param name="dataStyle">文件类型</param>
        /// <param name="dtpDate">DateTimePicker对象-日期选择</param>
        /// <param name="dgvObjDay">DataGridView对象-需导出的白班数据</param>
        /// <param name="dgvObjNight">DataGridView对象-需导出的夜班数据</param>
        public static void ExcelExportTD(Boolean isExport, String dataStyle, UIDatePicker dtpDate, DataGridView dgvObjDay, DataGridView dgvObjNight)
        {
            try
            {
                string date = dtpDate.Value.ToString("yyyy-MM-dd");

                //创建和初始化一个SaveFileDialog
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "导出Excel文件";//标题
                sfd.Filter = "Excel(*.xlsx)|*.xlsx";//设置文件类型
                sfd.FileName = dataStyle + date + "白班";//设置默认文件名
                sfd.DefaultExt = "xlsx";//设置默认格式（可以不设）
                sfd.AddExtension = true;//设置自动在文件名中添加扩展名
                if (!isExport)
                {
                    MessageBox.Show("查询失败，无法导出！");
                    return;
                }
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    int result1 = TransToExcel(sfd.FileName, dgvObjDay);
                    switch (result1)
                    {
                        //int 记录返回结果1.导出成功  2.文件重名  3.错误信息 0.成功  4.行数超过excel文件限制
                        case 1:
                            MessageBox.Show("导出成功:" + sfd.FileName);
                            break;
                        case 2:
                            MessageBox.Show("文件已经存在");//启用这行代码就不会覆盖文件
                            break;
                        case 4:
                            MessageBox.Show("行数超过excel限制");
                            break;
                        default:
                            break;
                    }
                }

                sfd.FileName = dataStyle + date + "夜班";//设置默认文件名
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    int result1 = TransToExcel(sfd.FileName, dgvObjNight);
                    switch (result1)
                    {
                        //int 记录返回结果1.导出成功  2.文件重名  3.错误信息 0.成功  4.行数超过excel文件限制
                        case 1:
                            MessageBox.Show("导出成功:" + sfd.FileName);
                            break;
                        case 2:
                            MessageBox.Show("文件已经存在");//启用这行代码就不会覆盖文件
                            break;
                        case 4:
                            MessageBox.Show("行数超过excel限制");
                            break;
                        default:
                            break;
                    }
                }

            }
            catch
            {
                MessageBox.Show("导出失败！");
            }
        }

        /// <summary>
        /// Excel格式统计详细数据导出（重载2）
        /// </summary>
        /// <param name="dataStyle">文件类型</param>
        /// <param name="dtpDate">DateTimePicker对象-日期选择</param>
        /// <param name="cobShift">ComboBox对象-班次选择</param>
        /// <param name="dgvObj">DataGridView对象-需导出的数据</param>
        public static void ExcelExportDD(Boolean isExport, String dataStyle, UIDatePicker dtpDate, UIComboBox cobShift, DataGridView dgvObj)
        {
            try
            {
                string date = dtpDate.Value.ToString("yyyy-MM-dd");
                string cbxSelect;

                //创建和初始化一个SaveFileDialog
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "导出Excel文件";//标题
                sfd.Filter = "Excel(*.xlsx)|*.xlsx";//设置文件类型
                if (cobShift.Text.Contains(":"))
                {
                    cbxSelect = "-" + cobShift.Text.Split(':')[0] + "时";
                }
                else
                {
                    cbxSelect = cobShift.Text;
                }
                sfd.FileName = dataStyle + date + cbxSelect;//设置默认文件名
                sfd.DefaultExt = "xlsx";//设置默认格式（可以不设）
                sfd.AddExtension = true;//设置自动在文件名中添加扩展名
                if (!isExport)
                {
                    MessageBox.Show("请先查询数据，再导出！");
                    return;
                }
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    int result1 = TransToExcel(sfd.FileName, dgvObj);
                    switch (result1)
                    {
                        //int 记录返回结果1.导出成功  2.文件重名  3.错误信息 0.成功  4.行数超过excel文件限制
                        case 1:
                            MessageBox.Show("导出成功:" + sfd.FileName);
                            break;
                        case 2:
                            MessageBox.Show("文件已经存在");//启用这行代码就不会覆盖文件
                            break;
                        case 4:
                            MessageBox.Show("行数超过excel限制");
                            break;
                        default:
                            break;
                    }
                }

            }
            catch
            {
                MessageBox.Show("导出失败！");
            }
        }

        /// <summary>
        /// Excel格式日志数据导出
        /// </summary>
        /// <param name="singalExport">导出标志，为true时表示数据查询成功</param>
        /// <param name="dataType">文件类型</param>
        /// <param name="dtpDateStart">查询起始时间</param>
        /// <param name="dtpDateEnd">查询终止时间</param>
        /// <param name="dgvObj">DataGridView对象-需导出的数据</param>
        public static void ExcelExportLog(Boolean isExport, String dataType, UIDatePicker dtpDateStart, UIDatePicker dtpDateEnd, DataGridView dgvObj)
        {
            try
            {
                string dateStart = dtpDateStart.Value.ToString("yyyy-MM-dd");

                //创建和初始化一个SaveFileDialog
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "导出Excel文件";//标题
                sfd.Filter = "Excel(*.xlsx)|*.xlsx";//设置文件类型
                sfd.FileName = dataType + dtpDateStart.Value.ToString("yyyyMMdd_HH_mm_ss") + "-" + dtpDateEnd.Value.ToString("yyyyMMdd_HH_mm_ss");//设置默认文件名
                sfd.DefaultExt = "xlsx";//设置默认格式（可以不设）
                sfd.AddExtension = true;//设置自动在文件名中添加扩展名
                if (!isExport)
                {
                    MessageBox.Show("请先查询数据，再导出！");
                    return;
                }
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    int result1 = TransToExcel(sfd.FileName, dgvObj);
                    switch (result1)
                    {
                        //int 记录返回结果1.导出成功  2.文件重名  3.错误信息 0.成功  4.行数超过excel文件限制
                        case 1:
                            MessageBox.Show("导出成功:" + sfd.FileName);
                            break;
                        case 2:
                            MessageBox.Show("文件已经存在");//启用这行代码就不会覆盖文件
                            break;
                        case 4:
                            MessageBox.Show("行数超过excel限制");
                            break;
                        default:
                            break;
                    }
                }

            }
            catch
            {
                MessageBox.Show("导出失败！");
            }
        }

        /// <summary>
        /// Excel格式主界面检测数据导出
        /// </summary>
        /// <param name="singalExport">导出标志，为true时表示数据查询成功</param>
        /// <param name="dataType">文件类型</param>
        /// <param name="dtpDateStart">查询起始时间</param>
        /// <param name="dtpDateEnd">查询终止时间</param>
        /// <param name="dgvObj">DataGridView对象-需导出的数据</param>
        public static void ExcelExportCheck(DataGridView dgvObj)
        {
            try
            {
                string date = DateTime.Now.ToLocalTime().ToString("yyyyMMdd-HHmmss");

                //创建和初始化一个SaveFileDialog
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "导出Excel文件";//标题
                sfd.Filter = "Excel(*.xlsx)|*.xlsx";//设置文件类型
                sfd.FileName = "数据" + date;
                sfd.DefaultExt = "xlsx";//设置默认格式（可以不设）
                sfd.AddExtension = true;//设置自动在文件名中添加扩展名
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    int result1 = TransToExcel(sfd.FileName, dgvObj);
                    switch (result1)
                    {
                        //int 记录返回结果1.导出成功  2.文件重名  3.错误信息 0.成功  4.行数超过excel文件限制
                        case 1:
                            MessageBox.Show("导出成功:" + sfd.FileName);
                            break;
                        case 2:
                            MessageBox.Show("文件已经存在");//启用这行代码就不会覆盖文件
                            break;
                        case 4:
                            MessageBox.Show("行数超过excel限制");
                            break;
                        default:
                            break;
                    }
                }

            }
            catch
            {
                MessageBox.Show("导出失败！");
            }
        }

        /// <summary>
        /// 将查询到的数据转换成Excel格式
        /// </summary>
        /// <param name="filePath">文件路径</param>
        /// <param name="dataGridView">DataGridView对象-要转换的数据</param>
        /// <returns>转换结果</returns>
        public static int TransToExcel(string filePath, DataGridView dataGridView)
        {
            //int 记录返回结果1.导出成功  2.文件重名  3.错误信息 0.成功  4.行数超过excel文件限制
            int result;

            FileStream fs = null;//创建一个新的文件流
            HSSFWorkbook workbook = null;//创建一个新的Excel文件
            ISheet sheet = null;//为Excel创建一张工作表

            //定义行数、列数、与当前Excel已有行数
            int rowCount = dataGridView.RowCount;//记录表格中的行数
            int colCount = dataGridView.ColumnCount;//记录表格中的列数

            //创建工作表
            try
            {
                fs = new FileStream(filePath, FileMode.Create, FileAccess.Write);
                workbook = new HSSFWorkbook();
                sheet = workbook.CreateSheet("Sheet1");
                IRow row = sheet.CreateRow(0);
                for (int j = 0; j < colCount; j++)  //列循环
                {
                    if (dataGridView.Columns[j].Visible && dataGridView.Rows[0].Cells[j].Value != null)
                    {
                        ICell cell = row.CreateCell(j);//创建列
                        cell.SetCellValue(dataGridView.Columns[j].HeaderText.ToString());//更改单元格值                  
                    }
                }
            }
            catch
            {
                result = 3;
                return result;
            }

            for (int i = 0; i < rowCount; i++)//行循环
            {
                //防止行数超过Excel限制
                if (i >= 65536)
                {
                    result = 4;
                    break;
                }
                IRow row = sheet.CreateRow(1 + i);  //创建行
                for (int j = 0; j < colCount; j++)  //列循环
                {
                    if (dataGridView.Columns[j].Visible && dataGridView.Rows[i].Cells[j].Value != null)
                    {
                        ICell cell = row.CreateCell(j);//创建列
                        cell.SetCellValue(dataGridView.Rows[i].Cells[j].Value.ToString());//填充单元格值                  
                    }
                }
            }
            try
            {
                workbook.Write(fs);
                result = 1;//成功
            }
            catch
            {
                result = 3;
                return result;
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                    fs.Dispose();
                }
                workbook = null;
            }
            return result;
        }
    }
}
