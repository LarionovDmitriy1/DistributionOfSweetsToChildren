using DistributionOfSweetsToChildren;
//Задание:

//конфеты([5, 8, 6, 4]) # возврат 9
//конфеты([1, 2, 4, 6]) # возврат 11
//конфеты([1, 6]) # возврат 5
//конфеты([]) # возврат -1
//конфеты([6]) # возвращают -1 (потому что только один ребенок)

var result = CandyDistributionWork.DistributionOfSweets(new List<int> { 5, 8, 6, 4 });
Console.WriteLine($"{result} конфет роздано");