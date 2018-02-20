from django import forms
from apps.habitacion.models import Habitacion

class HabitacionForm(forms.ModelForm):

    class Meta:
        model = Habitacion

        fields = [
            'Nombre',
            'Precio',
            'Estado',
        ]

        labels = {
            'Nombre': 'Nombre',
            'Precio': 'Precio',
            'Estado': 'Estado',
        }

        widgets = {
            'Nombre': forms.TextInput(attrs = {'class':'form-control input-sm'}),
            'Precio': forms.NumberInput(attrs = {'class':'form-control input-sm'}),
            'Estado': forms.CheckboxInput(attrs = {'class':'form-control input-sm'}),
        }
