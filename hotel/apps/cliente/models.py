from django.db import models

# Create your models here.

class Cliente(models.Model):
    Nombre = models.CharField(max_length = 35)
    ApellidoPaterno = models.CharField(max_length = 35)
    ApellidoMaterno = models.CharField(max_length = 35)
    FechaNacimiento = models.DateField()
    Telefono = models.CharField(max_length = 10)
    Email = models.EmailField()

    def NombreCompleto(self):
        cadena = "{0} {1}, {2}"
        return cadena.format(self.ApellidoPaterno, self.ApellidoMaterno, self.Nombre)

    def __str__(self):
        return self.NombreCompleto()
