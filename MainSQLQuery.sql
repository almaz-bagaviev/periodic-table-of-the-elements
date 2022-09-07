SELECT Ch.AtomicNumber, Ch.Symbol, Ch.[Name], Ch.AverageAtomicMass FROM ChemicalElementsTable Ch
WHERE Ch.AtomicNumber
BETWEEN 9 AND 11;
/*
AtomicNumber	Symbol	Name	AverageAtomicMass
9	            F		����	18,998
10	            Ne		����	20,179
11	            Na		������	22,99
*/

SELECT Ch.AtomicNumber, Ch.Symbol, Ch.[Name], Ch.AverageAtomicMass FROM ChemicalElementsTable Ch
WHERE
Ch.Symbol LIKE 'A%'
ORDER BY Ch.[Name];
/*
13	Al	���������	26,98154
18	Ar	�����		39,948
85	At	�����		[210]
79	Au	������		196,967
33	As	������		74,922
47	Ag	�������		107,868
*/

SELECT Lantan.AtomicNumber, Lantan.Symbol, Lantan.[Name], Lantan.AverageAtomicMass
FROM LanthanidesTable Lantan
WHERE Lantan.[Name] LIKE N'%��'
AND Lantan.Symbol LIKE 'T%';
/*
65	Tb	������	158,926
69	Tm	������	168,934
*/

SELECT TOP 5 CONCAT (N'���������� ����� �������� ', Ch.AtomicNumber,
N' ������ �������� ', Ch.Symbol,
N' ������� �������� ', Ch.[Name],
N' ������������� ������� ����� ', Ch.AverageAtomicMass) FullString
FROM ChemicalElementsTable Ch

/*
���������� ����� �������� 1 ������ �������� H ������� �������� ������� ������������� ������� ����� 1,008
���������� ����� �������� 2 ������ �������� He ������� �������� ����� ������������� ������� ����� 4,003
���������� ����� �������� 3 ������ �������� Li ������� �������� ����� ������������� ������� ����� 6,941
���������� ����� �������� 4 ������ �������� Be ������� �������� �������� ������������� ������� ����� 9,0122
���������� ����� �������� 5 ������ �������� B ������� �������� ��� ������������� ������� ����� 10,811
*/
