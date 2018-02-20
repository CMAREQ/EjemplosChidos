from django import forms
from apps.reservacion.models import Reservacion

class ReservacionForm(forms.ModelForm):

    class Meta:
        model = Reservacion

        fields = [
            'cliente',
            'habitacion',
            'FechaReservacion',
            'formaPago',
            'numPersonas',
        ]

        labels = {
            'cliente': 'Cliente',
            'habitacion': 'Habitacion',
            'FechaReservacion': 'Fecha de reservacion',
            'formaPago': 'Forma de Pago',
            'numPersonas': 'Numero de Personas',
        }

        widgets = {
            'cliente': forms.Select(attrs = {'class':'form-control input-sm'}),
            'habitacion': forms.Select(attrs = {'class':'form-control input-sm'}),
            'FechaReservacion': forms.DateInput(attrs = {'class':'form-control input-sm'}),
            'formaPago': forms.Select(attrs = {'class':'form-control input-sm'}),
            'numPersonas': forms.Select(attrs = {'class':'form-control input-sm'}),
        }
