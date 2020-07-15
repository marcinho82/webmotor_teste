import { Component, OnInit } from '@angular/core';
import { ServicesMotor } from '../Services/ServicesMotor';
import { Anuncio } from '../Models/Anuncio';
import { Router } from '@angular/router';

@Component({
  selector: 'app-counter-component',
  templateUrl: './counter.component.html'
})
export class CounterComponent implements OnInit {

  _servicesMotor: ServicesMotor;
  anuncio: Anuncio[];


  constructor(services : ServicesMotor, private route : Router) {
    this._servicesMotor = services;
  }

  excluir(id : any) {

    this._servicesMotor.deleteAnuncios(id).then(data => this.anuncio = data);
  }


  editar(id: any) {
    
    this.route.navigate(['/editar'], { state: { 'id': id } });
  }

  ngOnInit(){

    this._servicesMotor.getAnuncios().then(data => this.anuncio = data);
            
  }

}
