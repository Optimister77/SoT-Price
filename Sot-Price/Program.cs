//автор damernm
Console.WriteLine("Приветствую! Это прогрмма сделана для просмотра средних цен в игре SoT.");
while (true)
{
    string[] skulls = new string[20];
    skulls[0] = "Гнилой трофейный череп";
    skulls[1] = "Опальный трофейный череп";
    skulls[2] = "Злобный трофейный череп";
    skulls[3] = "Гнусный трофейный череп";
    skulls[4] = "Горелый гнилой трофейный череп";
    skulls[5] = "Горелый опальный трофейный череп";
    skulls[6] = "Горелый злобный трофейный череп";
    skulls[7] = "Горелый гнусный трофейный череп";
    skulls[8] = "Кораловый гнилой трофейный череп";
    skulls[9] = "Коралловый опальный трофейный череп";
    skulls[10] = "Кораловый злобный трофейный череп";
    skulls[11] = "Кораловый гнусный трофейный череп";
    skulls[12] = "Череп проклятых";
    skulls[13] = "Старший череп проклятых";
    skulls[14] = "Череп скелета капитана";
    skulls[15] = "Череп из цитадели";
    skulls[16] = "Череп пепельного ветра";
    string[] chests_relics = new string[25];
    chests_relics[0] = "Cундук отшельницы";
    chests_relics[1] = "Сундук морехода";
    chests_relics[2] = "Сундук мародёра";
    chests_relics[3] = "Сундук капитана";
    chests_relics[4] = "Горелый сундук отшельницы";
    chests_relics[5] = "Горелый сундук морехода";
    chests_relics[6] = "Горелый сундук мародёра";
    chests_relics[7] = "Горелый сундук капитана";
    chests_relics[8] = "Кораловый сундук отшельницы";
    chests_relics[9] = "Кораловый сундук морехода";
    chests_relics[10] = "Кораловый сундук мародёра";
    chests_relics[11] = "Кораловый сундук капитана";
    chests_relics[12] = "Сундук древних подношений";
    chests_relics[13] = "Сундук ярости";
    chests_relics[14] = "Сундук тысячи кружек";
    chests_relics[15] = "Сундук скорби";
    chests_relics[16] = "Бронзовые реликвии";
    chests_relics[17] = "Серебряные реликвии";
    chests_relics[18] = "Золотые реликвии";
    chests_relics[19] = "Драгоценные реликвии";
    chests_relics[20] = "Ревущий кубок";
    chests_relics[21] = "Серная шкатулка";
    chests_relics[22] = "Частица преисподней";
    chests_relics[23] = "Огненный гралль";
    string[] boxes = new string[100];
    boxes[0] = "Ящик с белым сахором";
    boxes[1] = "Ящик с редким чаем";
    boxes[2] = "Ящик с тонкими щелками";
    boxes[3] = "Ящик с изысканными специями";
    boxes[4] = "Ящик с вулканической породой";
    boxes[5] = "Ящик с мелкой рудой";
    boxes[6] = "Ящик с необычными минералами";
    boxes[7] = "Ящик с драгоценными камнями";
    boxes[8] = "Прах прокялтых";
    boxes[9] = "Урна с древним прахом";


    string[] cargo_box = new string[10];
    cargo_box[0] = "Ящик с роскошными тканями";
    cargo_box[1] = "Ящик с бутылками рома";
    cargo_box[2] = "Ящик с растениями";
    cargo_box[3] = "Ящик с дьявольскими тканями";
    cargo_box[4] = "Ящик с бутылками дьявольского рома";
    cargo_box[5] = "Ящик с дьявольскими растениями";


    string[] animals = new string[15];
    animals[0] = "Курица белая";
    animals[1] = "Курица пятнистая";
    animals[2] = "Курица чёрная";
    animals[3] = "Курица золотая";
    animals[4] = "Змея красно-белая";
    animals[5] = "Змея сине-чёрная";
    animals[6] = "Змея чёрная";
    animals[7] = "Змея золотая";
    animals[8] = "Свинья розовая";
    animals[9] = "Свинья пятнистая";
    animals[10] = "Свинья чёрная";
    animals[11] = "Свинья золотая";
    string[] animals_cen = new string[15];
    animals_cen[0] = "Обычная:10/По заданию:100";
    animals_cen[1] = "Обычная:30/По заданию:300";
    animals_cen[2] = "Обычная:70/По заданию:700";
    animals_cen[3] = "Обычная:150/По заданию:1500";
    animals_cen[4] = "Обычная:10/По заданию:100";
    animals_cen[5] = "Обычная:30/По заданию:300";
    animals_cen[6] = "Обычная:70/По заданию:700";
    animals_cen[7] = "Обычная:150/По заданию:1500";
    animals_cen[8] = "Обычная:10/По заданию:100";
    animals_cen[9] = "Обычная:30/По заданию:300";
    animals_cen[10] = "Обычная:70/По заданию:700";
    animals_cen[11] = "Обычная:150/По заданию:1500";
    string[] treasure_of_athena = new string[10];
    treasure_of_athena[0] = "Кубок из древнего клада";
    treasure_of_athena[1] = "Позолоченная реликвия из древнего клада";
    treasure_of_athena[2] = "Череп из древнего клада";
    treasure_of_athena[3] = "Гнусный череп из древнего клада";
    treasure_of_athena[4] = "Ящик с легендарными путествиями";
    treasure_of_athena[5] = "Бочка с древним порохом";
    treasure_of_athena[6] = "Сундук с легендами";
    treasure_of_athena[7] = "Горелый сундук с легендами";
    string[] barrels = new string[10];
    barrels[0] = "Пороховая бочка";
    barrels[1] = "Пороховая бочка из цитадели";
    string[] gem = new string[11];
    gem[0] = "Сапфир русалки";
    gem[1] = "Сапфир сирены";
    gem[2] = "Изумруд русалки";
    gem[3] = "Изумруд сирены";
    gem[4] = "Рубин русалки";
    gem[5] = "Рубин сирены";
    int[] skulls_cen = new int[20];
    skulls_cen[0] = 100;
    skulls_cen[1] = 300;
    skulls_cen[2] = 600;
    skulls_cen[3] = 1100;
    skulls_cen[4] = 300;
    skulls_cen[5] = 550;
    skulls_cen[6] = 1100;
    skulls_cen[7] = 2100;
    skulls_cen[8] = 201;
    skulls_cen[9] = 400;
    skulls_cen[10] = 1000;
    skulls_cen[11] = 1401;
    skulls_cen[12] = 1100;
    skulls_cen[13] = 2300;
    skulls_cen[14] = 1500;
    skulls_cen[15] = 3000;
    skulls_cen[16] = 7000;
    int[] chests_relics_cen = new int[30];
    chests_relics_cen[0] = 100;
    chests_relics_cen[1] = 200;
    chests_relics_cen[2] = 400;
    chests_relics_cen[3] = 800;
    chests_relics_cen[4] = 200;
    chests_relics_cen[5] = 400;
    chests_relics_cen[6] = 800;
    chests_relics_cen[7] = 1600;
    chests_relics_cen[8] = 200;
    chests_relics_cen[9] = 400;
    chests_relics_cen[10] = 700;
    chests_relics_cen[11] = 1500;
    chests_relics_cen[12] = 3600;
    chests_relics_cen[13] = 3200;
    chests_relics_cen[14] = 2400;
    chests_relics_cen[15] = 3200;
    chests_relics_cen[16] = 100;
    chests_relics_cen[17] = 200;
    chests_relics_cen[18] = 400;
    chests_relics_cen[19] = 800;
    chests_relics_cen[20] = 200;
    chests_relics_cen[21] = 400;
    chests_relics_cen[22] = 800;
    chests_relics_cen[23] = 1600;
    int[] boxes_cen = new int[15];
    boxes_cen[0] = 150;
    boxes_cen[1] = 400;
    boxes_cen[2] = 700;
    boxes_cen[3] = 1500;
    boxes_cen[4] = 400;
    boxes_cen[5] = 700;
    boxes_cen[6] = 1500;
    boxes_cen[7] = 2700;
    boxes_cen[8] = 1300;
    boxes_cen[9] = 3700;
    int[] treasure_of_athena_cen = new int[10];
    treasure_of_athena_cen[0] = 600;
    treasure_of_athena_cen[1] = 1500;
    treasure_of_athena_cen[2] = 600;
    treasure_of_athena_cen[3] = 1500;
    treasure_of_athena_cen[4] = 600;
    treasure_of_athena_cen[5] = 4000;
    treasure_of_athena_cen[6] = 5500;
    treasure_of_athena_cen[7] = 9000;
    int[] barrels_cen = new int[10];
    barrels_cen[0] = 150;
    barrels_cen[1] = 4400;
    int[] gem_cen = new int[10];
    gem_cen[0] = 1000;
    gem_cen[1] = 1000;
    gem_cen[2] = 1500;
    gem_cen[3] = 1500;
    gem_cen[4] = 2000;
    gem_cen[5] = 2000;
    string[] cargo_box_cen = new string[10];
    cargo_box_cen[0] = "700 / 500(Влажные) / 300(Промокшие) / 100(Вымокшие)";
    cargo_box_cen[1] = "700/500(Треснувшие)/300(Расколотые)/100(Разбитые)";
    cargo_box_cen[2] = "700/500(Увядающие)/300(Завядшие)/100(Высохшие)";
    cargo_box_cen[3] = "1400/1000(Влажные)/600(Промокшие)/200(Вымокшие)";
    cargo_box_cen[4] = "1400/1000(Треснувшие)/600(Расколотые)/200(Разбитые)";
    cargo_box_cen[5] = "1400/1000(Увядающие)/600(Завядшие)/200(Высохшие)";
    string[] db = new string[10];
    db[0] = "Ритуальный череп";
    int[] db_cen  = new int[10];
    db_cen[0] = 10;
    Console.WriteLine("Введите сокровище для поиска: ");
    string? poisk = Console.ReadLine();
    Console.Clear();
    for (int i = 0; i < skulls.Length; i++)
    {
        if (skulls[i] == poisk)
        {
            Console.WriteLine($"{skulls[i]} средняя цена: {skulls_cen[i]}");
            break;
        }
    }
    for (int i = 0; i < chests_relics.Length; i++)
    {
        if (chests_relics[i] == poisk)
        {
            Console.WriteLine($"{chests_relics[i]} средняя цена: {chests_relics_cen[i]}");
            break;
        }
    }
    for (int i = 0; i < boxes.Length; i++)
    {
        if (boxes[i] == poisk)
        {
            Console.WriteLine($"{boxes[i]} средняя цена: {boxes_cen[i]}");
            break;
        }
    }
    for (int i = 0; i < cargo_box.Length; i++)
    {
        if (cargo_box[i] == poisk)
        {
            Console.WriteLine($"{cargo_box[i]} цена: {cargo_box_cen[i]}");
            break;
        }
    }
    for (int i = 0; i < animals.Length; i++)
    {
        if (animals[i] == poisk)
        {
            Console.WriteLine($"{animals[i]}  цена: {animals_cen[i]}");
            break;
        }
    }
    for (int i = 0; i < treasure_of_athena.Length; i++)
    {
        if (treasure_of_athena[i] == poisk)
        {
            Console.WriteLine($"{treasure_of_athena[i]} средняя цена: {treasure_of_athena_cen[i]}");
            break;
        }
    }
    for (var i = 0; i < barrels.Length; i++)
    {
        if (barrels[i] == poisk)
        {
            Console.WriteLine($"{barrels[i]} средняя цена: {barrels_cen[i]}");
            break;
        }
    }
    for (int i = 0; i < gem.Length; i++)
    {
        if (gem[i] == poisk)
        {
            Console.WriteLine($"{gem[i]} средняя цена: {gem_cen[i]}");
            break;
        }
    }
    for (int i = 0; i < db.Length; i++)
    {
        if (db[i] == poisk)
        {
            Console.WriteLine($"{db[i]} цена: {db_cen[i]}");
            break;
        }
    }
    Console.WriteLine("Хотите повторить?(Да или Нет или нажмите Enter)");
    string? otvet = Console.ReadLine();
    if (otvet == "Да")
    {
        Console.Clear();
    }
    else if (otvet == "Нет")
    {
        break;
    }
    else Console.Clear();
}