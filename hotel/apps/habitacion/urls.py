from django.urls import path
from apps.habitacion.views import index_Habitacion, habitacion_view, lista_habitacion, editar_habitacion,eliminar_habitacion

urlpatterns = [
    path('', index_Habitacion, name = 'Hindex'),
    path('nuevo', habitacion_view, name = 'crear_habitacion'),
    path('ver', lista_habitacion, name = 'ver_habitacion'),
    path('editar/<idHab>', editar_habitacion, name = 'editar_habitacion'),
    path('eliminar/<idHab>', eliminar_habitacion, name = 'eliminar_habitacion'),
]
