import unittest
from practica2 import printFile
from practica2 import writeFile

class TestPractica2(unittest.TestCase):

    def test_printFile_caso1(self):
        self.assertEqual(printFile("printFile_caso1.txt"),"hola taco")

    def test_printFile_caso2(self):
        self.assertEqual(printFile("printFile_caso2.txt"), "")

    def test_printFile_caso3(self):
        self.assertEqual(printFile("printFile_caso3.txt"),"hola\nsalto\ntamal")


if __name__ == '__main__':
    unittest.main()
