import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs/operators';
import { Anuncio } from '../Models/Anuncio';


@Injectable()
export class ServicesMotor {

  constructor(private http: HttpClient) { }
  anuncio = new Anuncio();
  
  headers = { 'content-type': 'application/json' }
  connection: string = "https://localhost:44353/api/Motors"; 

  salvarAnuncio(id: number, marca: string, modelo: string, ano: number, quilometragem: number, versao:string, observacao: string) {

    this.anuncio.id = id;
    this.anuncio.ano = Number(ano);
    this.anuncio.quilometragem = Number(quilometragem);
    this.anuncio.modelo = modelo;
    this.anuncio.marca = marca;
    this.anuncio.observacao = observacao;
    this.anuncio.versao = versao;
          
    
    return this.http.post(this.connection,JSON.stringify(this.anuncio), {'headers': this.headers})
      .pipe(map(data => data)).toPromise();
  }

  getAnuncios() {
    return this.http.get<Anuncio[]>(this.connection).pipe(map(data => data)).toPromise();
  }

  deleteAnuncios(id : any) {
    return this.http.delete<Anuncio[]>(this.connection + '/' + id, { 'headers': this.headers }).pipe(map(data => data)).toPromise();
  }

  updateAnuncios(anuncio) {

   return this.http.post(this.connection, JSON.stringify(anuncio), { 'headers': this.headers }).toPromise();                                      

  }


  getAnuncioId(id : any) {

    return this.http.get<Anuncio>(this.connection + '/' + id).pipe(map(data => data)).toPromise();

  }
}
