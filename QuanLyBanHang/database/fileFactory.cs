﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;

namespace QuanLyBanHang.database
{
    class fileFactory<T>
    {
        public bool Save(List<T> list, string path)
        {
            try
            {
                FileStream fs = new FileStream(path, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, list);
                fs.Close();
                return true;

            }
            catch(Exception e)
            {
                throw e;
            }
        }
        public List<T> Load(string path)
        {
            List<T> list = new List<T>();
            try
            {
                FileStream fs = new FileStream(path, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                object data = bf.Deserialize(fs);
                list = data as List<T>;
                fs.Close();
                return list;
            }catch(Exception e)
            {
                throw e;
            }
        }
    }
}
