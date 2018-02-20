from django.db import models
from apps.cliente.models import Cliente
from apps.habitacion.models import Habitacion

# Create your models here.

class Reservacion(models.Model):
    cliente = models.ForeignKey(Cliente, null = False, blank = False, on_delete = models.CASCADE)
    habitacion = models.ForeignKey(Habitacion, null = False, blank = False, on_delete = models.CASCADE)
    FechaReservacion = models.DateField()
    Pago = (('E','Efectivo'), ('T', 'Tarjeta'))
    formaPago = models.CharField(max_length = 1, choices = Pago, default = 'T')
    Personas = (('1','1'), ('2', '2'), ('3', '3'), ('4','4'))
    numPersonas = models.CharField(max_length = 1, choices = Personas, default = '1')

    def save(self, *args, **kwargs):
        hab = Habitacion.objects.get(id = self.habitacion.id)
        hab.Estado = False
        hab.save()
        return super(Reservacion, self).save(*args,**kwargs)

    def __str__(self):
        cadena = "{0} => {1}"
        return cadena.format(self.cliente, self.habitacion.Nombre)
