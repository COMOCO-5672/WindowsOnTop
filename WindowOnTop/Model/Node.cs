using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowOnTop.Model
{
    //定义节点类Node
    public class Node
    {
        //构造函数
        public Node()
        {
            this.Nodes = new List<Node>();
        }
        public int ID { get; set; }//内码
        public string Name { get; set; }//名称
        public bool IsParent { get; set; }//是否父级
        public int OwnerID { get; set; }//上一级内码
        public List<Node> Nodes { get; set; }//节点集合
    }
}
