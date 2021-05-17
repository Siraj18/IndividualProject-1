using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndividualProject
{
	
	public partial class LibrarianForm : Form
	{
		private int maxPage = 0;
		List<ListViewItem> items = new List<ListViewItem>();
		List<string> publisherFiltr = new List<string>();
		List<string> authorFiltr = new List<string>();
		List<string> genreFiltr = new List<string>();
		List<string> limitFiltr = new List<string>();
		public LibrarianForm()
		{
			InitializeComponent();
			labelUser.Text = User.last_name + " " + User.first_name;
			radioButton1.Checked = true;
			// Назначение событий на кнопки
			buGetInformation.Click += BuGetInformation_Click;
			buGiveBook.Click += BuGiveBook_Click;
			buAdd.Click += BuAdd_Click;
			// Переключение вкладок
			buCatalog.Click += BuCatalog_Click;
			buBron.Click += BuBron_Click;
			buProfile.Click += BuProfile_Click;

			//
			buConfirm.Click += BuConfirm_Click;

			

			LoadBooks();
			UpdateFiltrs();
			UpdateList();
			
		}

		private void BuConfirm_Click(object sender, EventArgs e)
		{
			DBManager serverDb = new DBManager();
			string result = serverDb.ConfirmBook(textBoxConfirmCode.Text);
			MessageBox.Show(result);
		}

		private void BuPriemInformation_Click(object sender, EventArgs e)
		{
			DBManager serverDb = new DBManager();
			string result = serverDb.GiveBooksInformation(textBoxBookCode.Text);
			labelInformation.Text = result;
		}

		private void BuProfile_Click(object sender, EventArgs e)
		{
			tabControl1.SelectedIndex = 2;
		}

		private void BuBron_Click(object sender, EventArgs e)
		{
			tabControl1.SelectedIndex = 1;
		}

		private void BuCatalog_Click(object sender, EventArgs e)
		{
			tabControl1.SelectedIndex = 0;
		}

		private void BuAdd_Click(object sender, EventArgs e)
		{
			string name = textBoxName.Text;
			string author = textBoxAuthor.Text;
			string publisher = textBoxPublisher.Text;
			string count = textBoxCount.Text;
			string genre = textBoxGenre.Text;
			string ageLimit = textBoxLimit.Text;
			if (name == "" || author == "" || publisher == "" || count == "" || genre == "" || ageLimit == "")
			{
				MessageBox.Show("Неверные данные");
				return;
			}
			DBManager serverDb = new DBManager();
			string result = serverDb.AddBook(name, author, publisher, count, genre, ageLimit);
			MessageBox.Show(result);
			LoadBooks();
			UpdateList();
			UpdateFiltrs();
		}

		private void BuGiveBook_Click(object sender, EventArgs e)
		{
			DBManager serverDb = new DBManager();
			string result = serverDb.GiveBooksUser(textBoxBookCode.Text);
			MessageBox.Show(result);
		}

		private void BuGetInformation_Click(object sender, EventArgs e)
		{
			DBManager serverDb = new DBManager();
			string result = serverDb.GiveBooksInformation(textBoxBookCode.Text);
			labelInformation.Text = result;
		}

		private void button1_Click(object sender, EventArgs e)
		{

			UpdateList();
		}

		private void UpdateList()
		{
			
			listView1.Items.Clear();
			int onList = 0;
			if (radioButton1.Checked)
			{
				onList = 10;
			}
			else if (radioButton2.Checked)
			{
				onList = 20;
			}
			else if (radioButton3.Checked)
			{
				onList = 30;
			}
			else if (radioButton4.Checked)
			{
				onList = 50;
			}
			else if (radioButton5.Checked)
			{
				onList = 100;
			}

			int listNumber = int.Parse(labelPage.Text);       // страница

			
			int start = (listNumber - 1) * onList;
			

			maxPage = items.Count / onList;

			

			if (items.Count % onList == 0)
			{

			}
			else
			{
				maxPage += 1;
			}
			
			int count = 0;
			listView1.CheckBoxes = true;
			for (int i = start; i < items.Count; i++)
			{
				if (count >= onList) break;

				int n = count + 1;
				if (n % 2 == 0)
				{
					items[i].BackColor = Color.White;
				}
				else
				{
					items[i].BackColor = Color.Gray;
				}
				if (items[i].SubItems[2].Text == comboBox2.Text || comboBox2.Text == "Все")
				{
					if (items[i].SubItems[3].Text == comboBox1.Text || comboBox1.Text == "Все")
					{
						if (items[i].SubItems[5].Text == comboBox3.Text || comboBox3.Text == "Все")
						{
							if (items[i].SubItems[6].Text == comboBox4.Text || comboBox4.Text == "Все")
							{
								listView1.Items.Add(items[i]);
								count++;
							}
						}
					}
					
				}
				

				
			}

			
		}

		private void buNext_Click(object sender, EventArgs e)
		{
			if (labelPage.Text != maxPage.ToString())
			{
				int p = int.Parse(labelPage.Text);
				p += 1;
				labelPage.Text = p.ToString();
				UpdateList();
			}
		}

		private void buPrev_Click(object sender, EventArgs e)
		{
			if (labelPage.Text != "1")
			{
				int p = int.Parse(labelPage.Text);
				p -= 1;
				labelPage.Text = p.ToString();
				UpdateList();
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			labelPage.Text = maxPage.ToString();
			UpdateList();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			labelPage.Text = "1";
			UpdateList();
		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			
			UpdateList();
		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			if (int.Parse(labelPage.Text) > maxPage)
			{
				labelPage.Text = maxPage.ToString();
			}
			UpdateList();
		}

		private void radioButton3_CheckedChanged(object sender, EventArgs e)
		{
			if (int.Parse(labelPage.Text) > maxPage)
			{
				labelPage.Text = maxPage.ToString();
			}
			UpdateList();
		}

		private void radioButton4_CheckedChanged(object sender, EventArgs e)
		{
			if (int.Parse(labelPage.Text) > maxPage)
			{
				labelPage.Text = maxPage.ToString();
			}
			UpdateList();
		}

		private void radioButton5_CheckedChanged(object sender, EventArgs e)
		{
			if (int.Parse(labelPage.Text) > maxPage)
			{
				labelPage.Text = maxPage.ToString();
			}
			UpdateList();
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			int count = 0;
			for (int i = 0; i < listView1.Items.Count; i++)
			{
				if (listView1.Items[i].Checked)
				{
					items.Remove(listView1.Items[i]);
					count++;
				}
			}
			UpdateList();
			MessageBox.Show("Было удалено:" + count.ToString());
		}

		private void LoadBooks()
		{
			DBManager serverDb = new DBManager();
			string result = serverDb.LoadBooksInform();

			string[] rows = result.Split('\n');
			items.Clear();
			
			for (int i = 0; i < rows.Length - 1; i++)
			{
				string[] bookInfo = rows[i].Split(';');

				ListViewItem _item = new ListViewItem(bookInfo[4]);
				_item.SubItems.Add(bookInfo[0]);
				_item.SubItems.Add(bookInfo[1]);
				_item.SubItems.Add(bookInfo[2]);
				_item.SubItems.Add(bookInfo[3]);
				_item.SubItems.Add(bookInfo[5]);
				_item.SubItems.Add(bookInfo[6]);
				_item.BackColor = Color.Gray;
				if (!publisherFiltr.Contains(bookInfo[2])) publisherFiltr.Add(bookInfo[2]);
				if (!authorFiltr.Contains(bookInfo[1])) authorFiltr.Add(bookInfo[1]);
				if (!genreFiltr.Contains(bookInfo[5])) genreFiltr.Add(bookInfo[5]);
				if (!limitFiltr.Contains(bookInfo[6])) limitFiltr.Add(bookInfo[6]);
				items.Add(_item);
			}
		}

		private void listView1_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
		{
			e.Graphics.FillRectangle(Brushes.Blue, e.Bounds);
			e.DrawText();
		}

		private void listView1_DrawItem(object sender, DrawListViewItemEventArgs e)
		{
			e.DrawDefault = true;
		}

		private void LibrarianForm_Load(object sender, EventArgs e)
		{
			listView1.OwnerDraw = true;
		}
		private void UpdateFiltrs()
		{
			comboBox1.Items.Clear();
			comboBox2.Items.Clear();
			comboBox3.Items.Clear();
			comboBox4.Items.Clear();
			comboBox1.Items.Add("Все");
			comboBox1.SelectedIndex = 0;
			comboBox2.Items.Add("Все");
			comboBox2.SelectedIndex = 0;
			comboBox3.Items.Add("Все");
			comboBox3.SelectedIndex = 0;
			comboBox4.Items.Add("Все");
			comboBox4.SelectedIndex = 0;
			for (int i = 0; i < publisherFiltr.Count; i++)
			{
				comboBox1.Items.Add(publisherFiltr[i]);
				
			}
			for (int i = 0; i < authorFiltr.Count; i++)
			{
				comboBox2.Items.Add(authorFiltr[i]);

			}
			for (int i = 0; i < genreFiltr.Count; i++)
			{
				comboBox3.Items.Add(genreFiltr[i]);

			}
			for (int i = 0; i < limitFiltr.Count; i++)
			{
				comboBox4.Items.Add(limitFiltr[i]);

			}

		}

		private void button4_Click(object sender, EventArgs e)
		{
			UpdateList();
		}

		private void comboBox1_ContextMenuStripChanged(object sender, EventArgs e)
		{
			UpdateList();
			MessageBox.Show("hi");
		}

		private void comboBox1_TextChanged(object sender, EventArgs e)
		{
			UpdateList();
		}

		private void comboBox2_TextChanged(object sender, EventArgs e)
		{
			UpdateList();
		}

		private void comboBox3_TextChanged(object sender, EventArgs e)
		{
			UpdateList();
		}

		private void comboBox4_TextChanged(object sender, EventArgs e)
		{
			UpdateList();
		}

		private void UpdateColor()
		{
			for (int i = 0; i < listView1.Items.Count; i++)
			{
			
			}
		}
	}
}
