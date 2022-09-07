SELECT Ch.AtomicNumber, Ch.Symbol, Ch.[Name], Ch.AverageAtomicMass FROM ChemicalElementsTable Ch
WHERE Ch.AtomicNumber
BETWEEN 9 AND 11;
/*
AtomicNumber	Symbol	Name	AverageAtomicMass
9	            F		Фтор	18,998
10	            Ne		Неон	20,179
11	            Na		Натрий	22,99
*/

SELECT Ch.AtomicNumber, Ch.Symbol, Ch.[Name], Ch.AverageAtomicMass FROM ChemicalElementsTable Ch
WHERE
Ch.Symbol LIKE 'A%'
ORDER BY Ch.[Name];
/*
13	Al	Аллюминий	26,98154
18	Ar	Аргон		39,948
85	At	Астат		[210]
79	Au	Золото		196,967
33	As	Мышьяк		74,922
47	Ag	Серебро		107,868
*/

SELECT Lantan.AtomicNumber, Lantan.Symbol, Lantan.[Name], Lantan.AverageAtomicMass
FROM LanthanidesTable Lantan
WHERE Lantan.[Name] LIKE N'%ий'
AND Lantan.Symbol LIKE 'T%';
/*
65	Tb	Тербий	158,926
69	Tm	Туллий	168,934
*/

SELECT TOP 5 CONCAT (N'Порядковый номер элемента ', Ch.AtomicNumber,
N' Символ элемента ', Ch.Symbol,
N' Навание элемента ', Ch.[Name],
N' Относительная Атомная масса ', Ch.AverageAtomicMass) FullString
FROM ChemicalElementsTable Ch

/*
Порядковый номер элемента 1 Символ элемента H Навание элемента Водород Относительная Атомная масса 1,008
Порядковый номер элемента 2 Символ элемента He Навание элемента Гелий Относительная Атомная масса 4,003
Порядковый номер элемента 3 Символ элемента Li Навание элемента Литий Относительная Атомная масса 6,941
Порядковый номер элемента 4 Символ элемента Be Навание элемента Беррилий Относительная Атомная масса 9,0122
Порядковый номер элемента 5 Символ элемента B Навание элемента Бор Относительная Атомная масса 10,811
*/
