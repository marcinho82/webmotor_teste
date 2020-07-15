import { Component, Input, OnInit } from '@angular/core';
import { ServicesMotor } from '../Services/ServicesMotor';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent implements OnInit {

  @Input('marca') marca: string;
  @Input('modelo') modelo: string;
  @Input('versao') versao: string;
  @Input('ano') ano: number;
  @Input('quilometragem') quilometragem: number;
  @Input('observacao') observacao: string;
  id : number 

  _service: ServicesMotor;
  

 
  constructor(services: ServicesMotor) {
    this._service = services;
  }

  salvar() { 

    this._service.salvarAnuncio(this.id, this.marca,this.modelo,this.ano, this.quilometragem, this.versao, this.observacao).then(data => data);
   }

  ngOnInit() {
   
  }

}
