//Автор damernm
//Связь дискорд Damernm#3223
using System;
using System.Diagnostics;
Console.WriteLine("Приветствую! Это прогрмма сделана для просмотра средних цен в игре SoT.");
Console.WriteLine("Greetings! This program is designed to view average prices in the SoT game.");
Console.WriteLine("Введите язык программы/Enter the program language(En/Ru)");
string? language = Console.ReadLine();
while (true)
{
    string[] Name = new string[100];
    int[] Cen = new int[100];
    Name[0] = "Гнилой трофейный череп";
    Name[1] = "Опальный трофейный череп";
    Name[2] = "Злобный трофейный череп";
    Name[3] = "Гнусный трофейный череп";
    Name[4] = "Горелый гнилой трофейный череп";
    Name[5] = "Горелый опальный трофейный череп";
    Name[6] = "Горелый злобный трофейный череп";
    Name[7] = "Горелый гнусный трофейный череп";
    Name[8] = "Кораловый гнилой трофейный череп";
    Name[9] = "Коралловый опальный трофейный череп";
    Name[10] = "Кораловый злобный трофейный череп";
    Name[11] = "Кораловый гнусный трофейный череп";
    Name[12] = "Череп проклятых";
    Name[13] = "Старший череп проклятых";
    Name[14] = "Череп скелета капитана";
    Name[15] = "Череп из цитадели";
    Name[16] = "Череп пепельного ветра";
    Name[17] = "Cундук отшельницы";
    Name[18] = "Сундук морехода";
    Name[19] = "Сундук мародёра";
    Name[20] = "Сундук капитана";
    Name[21] = "Горелый сундук отшельницы";
    Name[22] = "Горелый сундук морехода";
    Name[23] = "Горелый сундук мародёра";
    Name[24] = "Горелый сундук капитана";
    Name[25] = "Кораловый сундук отшельницы";
    Name[26] = "Кораловый сундук морехода";
    Name[27] = "Кораловый сундук мародёра";
    Name[28] = "Кораловый сундук капитана";
    Name[29] = "Сундук древних подношений";
    Name[30] = "Сундук ярости";
    Name[31] = "Сундук тысячи кружек";
    Name[32] = "Сундук скорби";
    Name[33] = "Бронзовые реликвии";
    Name[34] = "Серебряные реликвии";
    Name[35] = "Золотые реликвии";
    Name[36] = "Драгоценные реликвии";
    Name[37] = "Ревущий кубок";
    Name[38] = "Серная шкатулка";
    Name[39] = "Частица преисподней";
    Name[40] = "Огненный гралль";
    Name[41] = "Ящик с белым сахором";
    Name[42] = "Ящик с редким чаем";
    Name[43] = "Ящик с тонкими щелками";
    Name[44] = "Ящик с изысканными специями";
    Name[45] = "Ящик с вулканической породой";
    Name[46] = "Ящик с мелкой рудой";
    Name[47] = "Ящик с необычными минералами";
    Name[48] = "Ящик с драгоценными камнями";
    Name[49] = "Прах прокялтых";
    Name[50] = "Урна с древним прахом";
    Name[51] = "Ящик с роскошными тканями";
    Name[52] = "Ящик с бутылками рома";
    Name[53] = "Ящик с растениями";
    Name[54] = "Ящик с дьявольскими тканями";
    Name[55] = "Ящик с бутылками дьявольского рома";
    Name[56] = "Ящик с дьявольскими растениями";
    Name[57] = "Курица белая";
    Name[58] = "Курица пятнистая";
    Name[59] = "Курица чёрная";
    Name[60] = "Курица золотая";
    Name[61] = "Змея красно-белая";
    Name[62] = "Змея сине-чёрная";
    Name[63] = "Змея чёрная";
    Name[64] = "Змея золотая";
    Name[65] = "Свинья розовая";
    Name[66] = "Свинья пятнистая";
    Name[67] = "Свинья чёрная";
    Name[68] = "Свинья золотая";
    Name[69] = "Кубок из древнего клада";
    Name[70] = "Позолоченная реликвия из древнего клада";
    Name[71] = "Череп из древнего клада";
    Name[72] = "Гнусный череп из древнего клада";
    Name[73] = "Ящик с легендарными путествиями";
    Name[74] = "Бочка с древним порохом";
    Name[75] = "Сундук с легендами";
    Name[76] = "Горелый сундук с легендами";
    Name[77] = "Пороховая бочка";
    Name[78] = "Пороховая бочка из цитадели";
    Name[79] = "Сапфир русалки";
    Name[80] = "Сапфир сирены";
    Name[81] = "Изумруд русалки";
    Name[82] = "Изумруд сирены";
    Name[83] = "Рубин русалки";
    Name[84] = "Рубин сирены";
    Cen[0] = 100;
    Cen[1] = 300;
    Cen[2] = 600;
    Cen[3] = 1100;
    Cen[4] = 300;
    Cen[5] = 550;
    Cen[6] = 1100;
    Cen[7] = 2100;
    Cen[8] = ~200;
    Cen[9] = 400;
    Cen[10] = 1000;
    Cen[11] = ~1400;
    Cen[12] = 1100;
    Cen[13] = 2300;
    Cen[14] = 1500;
    Cen[15] = 3000;
    Cen[16] = 10000;
    Cen[17] = 100;
    Cen[18] = 200;
    Cen[19] = 400;
    Cen[20] = 800;
    Cen[21] = 200;
    Cen[22] = 400;
    Cen[23] = 800;
    Cen[24] = 1600;
    Cen[25] = 200;
    Cen[26] = 400;
    Cen[27] = 700;
    Cen[28] = 1500;
    Cen[29] = 3600;
    Cen[30] = 3200;
    Cen[31] = 2400;
    Cen[32] = 3200;
    Cen[33] = 100;
    Cen[34] = 200;
    Cen[35] = 400;
    Cen[36] = 800;
    Cen[37] = 200;
    Cen[38] = 400;
    Cen[39] = 800;
    Cen[40] = 1600;
    Cen[41] = 150;
    Cen[42] = 400;
    Cen[43] = 700;
    Cen[44] = 1500;
    Cen[45] = 400;
    Cen[46] = 700;
    Cen[47] = 1500;
    Cen[48] = 2700;
    Cen[49] = 1300;
    Cen[50] = 3700;
    Cen[51] = 300;
    Cen[52] = 300;
    Cen[53] = 300;
    Cen[54] = 600;
    Cen[55] = 600;
    Cen[56] = 600;
    Cen[57] = 55;
    Cen[58] = 165;
    Cen[59] = 385;
    Cen[60] = 825;
    Cen[61] = 55;
    Cen[62] = 165;
    Cen[63] = 365;
    Cen[64] = 825;
    Cen[65] = 55;
    Cen[66] = 165;
    Cen[67] = 365;
    Cen[68] = 825;
    Cen[69] = 600;
    Cen[70] = 1500;
    Cen[71] = 600;
    Cen[72] = 1500;
    Cen[73] = 600;
    Cen[74] = 4000;
    Cen[75] = 5500;
    Cen[76] = 9000;
    Cen[77] = 150;
    Cen[78] = 4400;
    Cen[79] = 1000;
    Cen[80] = 1000;
    Cen[81] = 1500;
    Cen[82] = 1500;
    Cen[83] = 2000;
    Cen[84] = 2000;

    string[] Name_en = new string[100];
    Name_en[0] = "Rotten Trophy Skull";
    Name_en[1] = "Disgraced Trophy Skull";
    Name_en[2] = "Evil Trophy Skull";
    Name_en[3] = "Vile Trophy Skull";
    Name_en[4] = "Burnt Rotten Trophy Skull";
    Name_en[5] = "Burnt Disgraced Trophy Skull";
    Name_en[6] = "Burnt Evil Trophy Skull";
    Name_en[7] = "Burnt Vile Trophy Skull";
    Name_en[8] = "Coral Rotten Trophy Skull";
    Name_en[9] = "Coral Disgraced Trophy Skull";
    Name_en[10] = "Coral Evil Trophy Skull";
    Name_en[11] = "Coral Vile Trophy Skull";
    Name_en[12] = "Skull of the Damned";
    Name_en[13] = "Senior Skull of the Damned";
    Name_en[14] = "Captain's Skeleton skull";
    Name_en[15] = "Skull from the Citadel";
    Name_en[16] = "Skull of the ashen wind";
    Name_en[17] = "Hermit's Chest";
    Name_en[18] = "Sailor's Chest";
    Name_en[19] = "Marauder's Chest";
    Name_en[20] = "Captain's Chest";
    Name_en[21] = "Burnt Hermit's Chest";
    Name_en[22] = "Burnt Sailor's chest";
    Name_en[23] = "The Marauder's Burnt Chest";
    Name_en[24] = "Captain's Burnt Chest";
    Name_en[25] = "Hermit's Coral Chest";
    Name_en[26] = "Sailor's Coral Chest";
    Name_en[27] = "Marauder's Coral Chest";
    Name_en[28] = "Captain's Coral Chest";
    Name_en[29] = "Chest of Ancient Offerings";
    Name_en[30] = "Chest of Rage";
    Name_en[31] = "Chest of a thousand mugs";
    Name_en[32] = "Chest of Sorrow";
    Name_en[33] = "Bronze Relics";
    Name_en[34] = "Silver Relics";
    Name_en[35] = "Golden Relics";
    Name_en[36] = "Precious Relics";
    Name_en[37] = "Roaring Cup";
    Name_en[38] = "Sulfur box";
    Name_en[39] = "Particle of the underworld";
    Name_en[40] = "Fire Grall";
    Name_en[41] = "Box with white sugar";
    Name_en[42] = "Box of rare tea";
    Name_en[43] = "Box with thin slits";
    Name_en[44] = "Box with exquisite spices";
    Name_en[45] = "Volcanic rock crate";
    Name_en[46] = "Small ore box";
    Name_en[47] = "Box with unusual minerals";
    Name_en[48] = "Jewel Box";
    Name_en[49] = "The ashes of the damned";
    Name_en[50] = "Urn with ancient ashes";
    Name_en[51] = "Box with luxury fabrics";
    Name_en[52] = "A box with bottles of rum";
    Name_en[53] = "Box with plants";
    Name_en[54] = "The box with the devil's fabrics";
    Name_en[55] = "A box with bottles of devil rum";
    Name_en[56] = "Box with devil plants";
    Name_en[57] = "White chicken";
    Name_en[58] = "Spotted chicken";
    Name_en[59] = "Black chicken";
    Name_en[60] = "Golden chicken";
    Name_en[61] = "Red and white snake";
    Name_en[62] = "Blue-black snake";
    Name_en[63] = "Black snake";
    Name_en[64] = "Golden snake";
    Name_en[65] = "Pink pig";
    Name_en[66] = "Spotted pig";
    Name_en[67] = "Black pig";
    Name_en[68] = "Golden pig";
    Name_en[69] = "Cup from an ancient treasure";
    Name_en[70] = "Gilded relic from an ancient treasure";
    Name_en[71] = "Skull from an ancient treasure";
    Name_en[72] = "A vile skull from an ancient treasure";
    Name_en[73] = "Box with legendary journeys";
    Name_en[74] = "A barrel of ancient gunpowder";
    Name_en[75] = "Legend Chest";
    Name_en[76] = "Burnt chest with legends";
    Name_en[77] = "Powder keg";
    Name_en[78] = "Powder keg from the citadel";
    Name_en[79] = "Mermaid Sapphire";
    Name_en[80] = "Sapphire of the siren";
    Name_en[81] = "Mermaid Emerald";
    Name_en[83] = "Ruby of the mermaid";
    Name_en[84] = "Ruby of the siren";
    if (language == "Ru")
    {
        Console.WriteLine("Введите сокровище для поиска: ");
        string poisk = Console.ReadLine();
        for (int i = 0; i < Name.Length; i++)
        {
            if (Name[i] == poisk)
            {
                Console.WriteLine($"Средняя цена:{Cen[i]}");
            }
        }

        Console.WriteLine("Хотите Продолжить?(Да или Нет)");
        string pr = Console.ReadLine();
        if (pr == "Да")
        {
            Console.Clear();
        }
        else if (pr == "Нет")
        {
            break;
        }
        else Console.Clear();
    }
    else if (language == "En")
    {
        Console.WriteLine("Enter the treasure to search for: ");
        string poisk = Console.ReadLine();
        for (int i = 0; i < Name_en.Length; i++)
        {
            if (Name_en[i] == poisk)
            {
                Console.WriteLine($"Average price:{Cen[i]}");
            }
        }

        Console.WriteLine("Do You Want To Continue?(Yes or No)");
        string pr = Console.ReadLine();
        if (pr == "Yes")
        {
            Console.Clear();
        }
        else if (pr == "No")
        {
            break;
        }
        else Console.Clear();
    }
}