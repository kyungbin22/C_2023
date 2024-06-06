using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZstdSharp.Unsafe;

namespace winform_Team_Project
{
    internal class menu_item
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
    }
    internal class menu_info
    {
        public menu_item tteok1 { get; set; } = new menu_item
        {
            Name = "삼육 떡볶이",
            Quantity = 1,
            Price = 3000        
        };
        public menu_item tteok2 { get; set; } = new menu_item
        {
            Name = "삼육 로제 떡볶이",
            Quantity = 1,
            Price = 3500
        };
        public menu_item tteok3 { get; set; } = new menu_item
        {
            Name = "삼육 치즈 떡볶이",
            Quantity = 1,
            Price = 3500
        };
        public menu_item tteok4 { get; set; } = new menu_item
        {
            Name = "삼육 라볶이",
            Quantity = 1,
            Price = 3500
        };
        public menu_item tteok5 { get; set; } = new menu_item
        {
            Name = "삼육 프리미엄",
            Quantity = 1,
            Price = 4500
        };
        public menu_item cup1 { get; set; } = new menu_item
        {
            Name = "삼육 김치 컵밥",
            Quantity = 1,
            Price = 2500
        };
        public menu_item cup2 { get; set; } = new menu_item
        {
            Name = "삼육 참치 컵밥",
            Quantity = 1,
            Price = 2500
        };
        public menu_item kim1 { get; set; } = new menu_item
        {
            Name = "삼육 김밥",
            Quantity = 1,
            Price = 2500
        };
        public menu_item kim2 { get; set; } = new menu_item
        {
            Name = "삼육 치즈 김밥",
            Quantity = 1,
            Price = 3000
        };
        public menu_item set1 { get; set; } = new menu_item
        {
            Name = "SDA 세트1",
            Quantity = 1,
            Price = 6000
        };
        public menu_item set2 { get; set; } = new menu_item
        {
            Name = "SDA 세트2",
            Quantity = 1,
            Price = 8500
        };
        public menu_item set3 { get; set; } = new menu_item
        {
            Name = "SDA 프리미엄",
            Quantity = 1,
            Price = 13500
        };
        public menu_item fry1 { get; set; } = new menu_item
        {
            Name = "어묵 튀김",
            Quantity = 1,
            Price = 2500
        };
        public menu_item fry2 { get; set; } = new menu_item
        {
            Name = "김말이 튀김",
            Quantity = 1,
            Price = 2500
        };
        public menu_item fry3 { get; set; } = new menu_item
        {
            Name = "오징어 튀김",
            Quantity = 1,
            Price = 2500
        };
        public menu_item fry4 { get; set; } = new menu_item
        {
            Name = "닭껍질 튀김",
            Quantity = 1,
            Price = 3000
        };
        public menu_item fry5 { get; set; } = new menu_item
        {
            Name = "치킨링",
            Quantity = 1,
            Price = 3000
        };
        public menu_item fry6 { get; set; } = new menu_item
        {
            Name = "피카츄 돈까스",
            Quantity = 1,
            Price = 3000
        };
        public menu_item des1 { get; set; } = new menu_item
        {
            Name = "삼육 팥빙수",
            Quantity = 1,
            Price = 4000
        };
        public menu_item des2 { get; set; } = new menu_item
        {
            Name = "슬러쉬",
            Quantity = 1,
            Price = 1500
        };
        public menu_item f_set1 { get; set; } = new menu_item
        {
            Name = "모둠 튀김1",
            Quantity = 1,
            Price = 6000
        };
        public menu_item f_set2 { get; set; } = new menu_item
        {
            Name = "모둠 튀김2",
            Quantity = 1,
            Price = 7000
        };
        public menu_item top1 { get; set; } = new menu_item
        {
            Name = "치즈 토핑",
            Quantity = 1,
            Price = 1000
        };
        public menu_item top2 { get; set; } = new menu_item
        {
            Name = "소세지 토핑",
            Quantity = 1,
            Price = 1000
        };
        public menu_item top3 { get; set; } = new menu_item
        {
            Name = "어묵 토핑",
            Quantity = 1,
            Price = 1000
        };
        public menu_item top4 { get; set; } = new menu_item
        {
            Name = "치킨링 토핑",
            Quantity = 1,
            Price = 2000
        };
        public menu_item drink1 { get; set; } = new menu_item
        {
            Name = "쿨피스",
            Quantity = 1,
            Price = 2500
        };
        public menu_item drink2 { get; set; } = new menu_item
        {
            Name = "탄산 음료",
            Quantity = 1,
            Price = 2500
        };
        public menu_item drink3 { get; set; } = new menu_item
        {
            Name = "삼육 두유",
            Quantity = 1,
            Price = 1500
        };
        public menu_item drink4 { get; set; } = new menu_item
        {
            Name = "삼육 메론 두유",
            Quantity = 1,
            Price = 1500
        };
        public menu_item dan { get; set; } = new menu_item
        {
            Name = "단무지",
            Quantity = 1,
            Price = 1000
        };
    }
}
