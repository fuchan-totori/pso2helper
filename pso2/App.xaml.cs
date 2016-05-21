using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Linq;

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
        /// 打撃力
        /// </summary>
        private byte power;
        /// <summary>
        /// 射撃力
        /// </summary>
        private byte shoot;
        /// <summary>
        /// 法撃力
        /// </summary>
        private byte tech;
        /// <summary>
        /// 打撃防御
        /// </summary>
        private byte body;
        /// <summary>
        /// 射撃防御
        /// </summary>
        private byte react;
        /// <summary>
        /// 法撃防御
        /// </summary>
        private byte mind;
        /// <summary>
        /// 技量
        /// </summary>
        private byte arm;
        /// <summary>
        /// HP
        /// </summary>
        private byte hp;
        /// <summary>
        /// PP
        /// </summary>
        private byte pp;
        /// <summary>
        /// 打撃耐性
        /// </summary>
        private byte blres;
        /// <summary>
        /// 射撃耐性
        /// </summary>
        private byte stres;
        /// <summary>
        /// 法撃耐性
        /// </summary>
        private byte mires;
        /// <summary>
        /// 炎耐性
        /// </summary>
        private byte flres;
        /// <summary>
        /// 氷耐性
        /// </summary>
        private byte icres;
        /// <summary>
        /// 雷耐性
        /// </summary>
        private byte scres;
        /// <summary>
        /// 風耐性
        /// </summary>
        private byte wires;
        /// <summary>
        /// 光耐性
        /// </summary>
        private byte lires;
        /// <summary>
        /// 闇耐性
        /// </summary>
        private byte glres;

        public Ability()
        {
            
        }
        public Ability(int num)
        {
            this.code = num;
        }
       
        public int Code
        {
            set { this.code = value; }
            get { return code; }
        }
        public string Name
        {
            set { this.name = value; }
            get { return name; }
        }
        public byte Power
        {
            set { this.power = value; }
            get { return power; }
        }
        public byte Shoot
        {
            set { this.shoot = value; }
            get { return shoot; }
        }
        public byte Tech
        {
            set { this.tech = value; }
            get { return tech; }
        }
        public byte Body
        {
            set { this.body = value; }
            get { return body; }
        }
        public byte React
        {
            set { this.react = value; }
            get { return react; }
        }
        public byte Mind
        {
            set { this.mind = value; }
            get { return mind; }
        }
        public byte Arm
        {
            set { this.arm = value; }
            get { return arm; }
        }
        public byte Hp
        {
            set { this.hp = value; }
            get { return hp; }
        }
        public byte Pp
        {
            set { this.pp = value; }
            get { return pp; }
        }
        public byte Blres
        {
            set { this.blres = value; }
            get { return blres; }
        }
        public byte Stres
        {
            set { this.stres = value; }
            get { return stres; }
        }
        public byte Mires
        {
            set { this.mires = value; }
            get { return mires; }
        }
        public byte Flres
        {
            set { this.flres = value; }
            get { return flres; }
        }
        public byte Icres
        {
            set { this.icres = value; }
            get { return icres; }
        }
        public byte Scres
        {
            set { this.scres = value; }
            get { return scres; }
        }
        public byte Wires
        {
            set { this.wires = value; }
            get { return wires; }
        }
        public byte Lires
        {
            set { this.lires = value; }
            get { return lires; }
        }
        public byte Glres
        {
            set { this.glres = value; }
            get { return glres; }
        }
    }
    
    /// <summary>
    /// 
    /// </summary>
    public class Material
    {
       
    }
}
