from django.db import models

# Create your models here.
class Habitacion(models.Model):
    Nombre = models.CharField(max_length = 20)
    Precio = models.PositiveIntegerField()
    Estado = models.BooleanField(default = True)

    def __str__(self):
        return "{0} (${1})".format(self.Nombre, self.Precio)
