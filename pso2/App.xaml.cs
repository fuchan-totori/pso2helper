using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace pso2
{
    /// <summary>
    /// App.xaml の相互作用ロジック
    /// </summary>
    public class Data
    {
        public string Text
        {
            get { return "Hello, World!\n"; }
        }
    }

    /// <summary>
    /// 特殊能力を表すクラス
    /// </summary>
    public class Ability
    {
        /// <summary>
        /// 特殊能力の通し番号
        /// </summary>
        private int code;
        /// <summary>
        /// 特殊能力名
        /// </summary>
        private string name;
        /// <summary>
        /// 特殊能力の詳細
        /// </summary>
        private string detail;
        public Ability() : this(0)
        {

        }
        public Ability(int num)
        {
            this.code = num;
        }
        public int Code
        {
            get { return code; }
        }
    }
    
    /// <summary>
    /// 
    /// </summary>
    public class Material
    {
       
    }
}
