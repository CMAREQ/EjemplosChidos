from django import forms
from apps.cliente.models import Cliente

class ClienteForm(forms.ModelForm):

    class Meta:
        model = Cliente

        fields = [
            'Nombre',
            'ApellidoPaterno',
            'ApellidoMaterno',
            'FechaNacimiento',
            'Telefono',
            'Email',
        ]

        labels = {
            'Nombre': 'Nombre',
            'ApellidoPaterno': 'Apellido Paterno',
            'ApellidoMaterno': 'Apellido Materno',
            'FechaNacimiento': 'Fecha de Nacimiento',
            'Telefono': 'Telefono',
            'Email': 'Email',
        }

        widgets = {
            'Nombre': forms.TextInput(attrs = {'class':'form-control input-sm'}),
            'ApellidoPaterno': forms.TextInput(attrs = {'class':'form-control input-sm'}),
            'ApellidoMaterno': forms.TextInput(attrs = {'class':'form-control input-sm'}),
            'FechaNacimiento': forms.DateInput(attrs = {'class':'form-control input-sm'}),
            'Telefono': forms.TextInput(attrs = {'class':'form-control input-sm'}),
            'Email': forms.EmailInput(attrs = {'class':'form-control input-sm'}),
        }
