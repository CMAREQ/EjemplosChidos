from django.urls import path
from apps.reservacion.views import index_Reservacion, reservacion_view, lista_reservacion, editar_reservacion, eliminar_reservacion

urlpatterns = [
    path('', index_Reservacion, name = 'Rindex'),
    path('nuevo', reservacion_view, name = 'crear_reservacion'),
    path('ver', lista_reservacion, name = 'ver_reservacion'),
    path('editar/<idRes>', editar_reservacion, name = 'editar_reservacion'),
    path('eliminar/<idRes>', eliminar_reservacion, name = 'eliminar_reservacion'),
]
