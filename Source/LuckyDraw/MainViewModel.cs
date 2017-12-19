﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;

namespace LuckyDraw
{
    /// <summary>
    /// 主页面的ViewModel
    /// </summary>
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public MainViewModel()
        {
            //LoadData();
            TestData();
            _random = new Random();
        }

        private Random _random;

        /// <summary>
        /// 剩余奖品数
        /// </summary>
        public int PrizeCount
        {
            get
            {
                return _prizesList.Where(x => x.IsUsed == false).Count();
            }
        }

        /// <summary>
        /// 剩余待抽奖人数
        /// </summary>
        public int PeopleCount
        {
            get
            {
                return _peopleList.Where(x => x.IsUsed == false).Count();
            }
        }

        #region 界面滚动列表数据
        private ObservableCollection<Prize> _prizesList = new ObservableCollection<Prize>();
        private ObservableCollection<Person> _peopleList = new ObservableCollection<Person>();

        /// <summary>
        /// 剩余奖品列表
        /// </summary>
        public ObservableCollection<Prize> PrizesList
        {
            get
            {
                return _prizesList;
            }
        }

        /// <summary>
        /// 剩余抽奖人数列表
        /// </summary>
        public ObservableCollection<Person> PeopleList
        {
            get
            {
                return _peopleList;
            }
        }

        /// <summary>
        /// 随机取得奖品
        /// </summary>
        public Prize RandomPrize
        {
            get
            {
                var list = _prizesList.Where(x => x.IsUsed == false).ToList();
                if (list.Count > 0)
                {
                    var prize = list[_random.Next(list.Count)];
                    prize.IsUsed = true;
                    return prize;
                }

                return null;
            }
        }

        /// <summary>
        /// 随机取得得奖者
        /// </summary>
        public Person RandomPerson
        {
            get
            {
                var list = _peopleList.Where(x => x.IsUsed == false).ToList();
                if (list.Count > 0)
                {
                    var person = list[_random.Next(list.Count)];
                    person.IsUsed = true;
                    return person;
                }

                return null;
            }
        }
        #endregion

        #region 奖品及中奖者名称显示
        private string _prize1 = "";
        private string _prize2 = "";
        private string _prize3 = "";
        private string _prize4 = "";
        private string _prize5 = "";
        private string _prize6 = "";
        private string _prize7 = "";
        private string _prize8 = "";
        private string _prize9 = "";
        private string _prize10 = "";
        private string _person1 = "";
        private string _person2 = "";
        private string _person3 = "";
        private string _person4 = "";
        private string _person5 = "";
        private string _person6 = "";
        private string _person7 = "";
        private string _person8 = "";
        private string _person9 = "";
        private string _person10 = "";

        public string Prize1
        {
            get
            {
                return _prize1;
            }

            set
            {
                _prize1 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Prize1"));
            }
        }

        public string Prize2
        {
            get
            {
                return _prize2;
            }

            set
            {
                _prize2 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Prize2"));
            }
        }

        public string Prize3
        {
            get
            {
                return _prize3;
            }

            set
            {
                _prize3 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Prize3"));
            }
        }

        public string Prize4
        {
            get
            {
                return _prize4;
            }

            set
            {
                _prize4 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Prize4"));
            }
        }

        public string Prize5
        {
            get
            {
                return _prize5;
            }

            set
            {
                _prize5 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Prize5"));
            }
        }

        public string Prize6
        {
            get
            {
                return _prize6;
            }

            set
            {
                _prize6 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Prize6"));
            }
        }

        public string Prize7
        {
            get
            {
                return _prize7;
            }

            set
            {
                _prize7 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Prize7"));
            }
        }

        public string Prize8
        {
            get
            {
                return _prize8;
            }

            set
            {
                _prize8 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Prize8"));
            }
        }

        public string Prize9
        {
            get
            {
                return _prize9;
            }

            set
            {
                _prize9 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Prize9"));
            }
        }

        public string Prize10
        {
            get
            {
                return _prize10;
            }

            set
            {
                _prize10 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Prize10"));
            }
        }

        public string Person1
        {
            get
            {
                return "恭喜你\n\r" + _person1;
            }

            set
            {
                _person1 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Person1"));
            }
        }

        public string Person2
        {
            get
            {
                return _person2;
            }

            set
            {
                _person2 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Person2"));
            }
        }

        public string Person3
        {
            get
            {
                return _person3;
            }

            set
            {
                _person3 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Person3"));
            }
        }

        public string Person4
        {
            get
            {
                return _person4;
            }

            set
            {
                _person4 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Person4"));
            }
        }

        public string Person5
        {
            get
            {
                return _person5;
            }

            set
            {
                _person5 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Person5"));
            }
        }

        public string Person6
        {
            get
            {
                return _person6;
            }

            set
            {
                _person6 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Person6"));
            }
        }

        public string Person7
        {
            get
            {
                return _person7;
            }

            set
            {
                _person7 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Person7"));
            }
        }

        public string Person8
        {
            get
            {
                return _person8;
            }

            set
            {
                _person8 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Person8"));
            }
        }

        public string Person9
        {
            get
            {
                return _person9;
            }

            set
            {
                _person9 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Person9"));
            }
        }

        public string Person10
        {
            get
            {
                return _person10;
            }

            set
            {
                _person10 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Person10"));
            }
        }
        #endregion

        private void LoadData()
        {
            //todo:读取奖品，抽奖人，中奖列表三个csv文件，更新数据列表
        }

        private void TestData()
        {
            //测试数据
            _prizesList.Clear();
            _peopleList.Clear();
            for (int i = 1; i <= 45; i++)
            {
                _prizesList.Add(new Prize()
                {
                    ID = i,
                    Name = "Prize_" + i.ToString(),
                    IsUsed = false
                });
            }

            for (int i = 1; i <= 1000; i++)
            {
                _peopleList.Add(new Person()
                {
                    ID = i,
                    Name = "Persion_" + i.ToString(),
                    IsUsed = false
                });
            }
        }

        public bool WriteData(Dictionary<Prize, Person> list)
        {
            try
            {
                //写入csv文件记录
                StreamWriter writer = new StreamWriter("result.csv", true, Encoding.UTF8);
                foreach (var i in list)
                {
                    string temp = i.Key.ID + "," + i.Value.ID + ","
                        + i.Key.Name + "," + i.Value.Name;
                    writer.WriteLine(temp);
                }

                writer.Flush();
                writer.Close();

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("存储信息失败，请检查得奖结果文件是否被占用!" +
                    "\n\r" + "本次抽奖不生效！");
                return false;
            }
        }
    }

    /// <summary>
    /// 奖品
    /// </summary>
    public class Prize
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Uri { get; set; }
        public bool IsUsed { get; set; }
    }

    /// <summary>
    /// 抽奖者
    /// </summary>
    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsUsed { get; set; }
    }
}
