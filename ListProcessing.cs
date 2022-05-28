using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace PonomarevLab2
{
    class ListProcessing
    {
        public SingleLinkedList list;
        ListBox listBox;
        static bool startsHere(int ind, SingleLinkedList subList, SingleLinkedList list)
        {
            for (int i = ind; i < ind + subList.Length; i++)
                if (list[i] != subList[i - ind])
                    return false;
            return true;
        }
        public ListProcessing(SingleLinkedList list, ListBox listBox)
        {
            this.listBox = listBox;
            listBox.Items.Clear();
            if (list != null)
                this.list = list;
            else
                listBox.Items.Add("Список не создан");

        }
        public void FindSub()
        {
            EnterForm getElements = new EnterForm("Введите список через пробел:", 0);
            getElements.ShowDialog();
            while (getElements.DialogResult != DialogResult.Cancel) ;
            SingleLinkedList subList = new SingleLinkedList(getElements.parsed);
            List<string> indexes = new List<string>();
            for (int i = 0; i <= list.Length - subList.Length; i++)
                if (startsHere(i, subList, list))
                    indexes.Add($"{i + 1} ");
            MessageBox.Show(String.Concat(indexes));
        }
        public void Prepend()
        {
            EnterForm getData = new EnterForm("Введите элемент:", 1);
            getData.ShowDialog();
            while (getData.DialogResult != DialogResult.Cancel) ;
            if (getData.parsed != null)
            {
                list.InsertBeforeFirst(getData.parsed[0]);
                listBox.Items.Insert(0, getData.parsed[0]);
            }
        }
        public void Append()
        {
            EnterForm getData = new EnterForm("Введите элемент:", 1);
            getData.ShowDialog();
            while (getData.DialogResult != DialogResult.Cancel) ;
            if (getData.parsed != null)
            {

                 list.InsertAfterLast(getData.parsed[0]);
                 listBox.Items.Insert(listBox.Items.Count, getData.parsed[0]);
            }
        }
        public void Insert()
        {
            int index, data;
            EnterForm getData = new EnterForm("Введите индекс и вставляемое значение через пробел:", 2);
            getData.ShowDialog();
            while (getData.DialogResult != DialogResult.Cancel) ;
            if (getData.parsed != null)
            {
                (index, data) = (getData.parsed[0], getData.parsed[1]);
                list.Insert(index, data);
                listBox.Items.Insert(index, data);
            }
        }
        public void DeleteFirst()
        {
            list.DeleteFirst();
            listBox.Items.RemoveAt(0);
        }
        public void DeleteLast()
        {
            list.DeleteLast();
            listBox.Items.RemoveAt(listBox.Items.Count - 1);
        }
        public void Delete()
        {
            EnterForm getData = new EnterForm("Введите индекс:", 1);
            getData.ShowDialog();
            while (getData.DialogResult != DialogResult.Cancel) ;
            if (getData.parsed != null)
            {
                list.RemoveAt(getData.parsed[0]);
                listBox.Items.RemoveAt(getData.parsed[0]);
            }
        }
        public void Destroy()
        {
            list.DeleteList();
            listBox.Items.Clear();
            listBox.Items.Add("Список не создан");
            list = null;
        }
    }
}
