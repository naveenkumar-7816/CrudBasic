import { Component, OnDestroy } from '@angular/core';
import { AddCategoryRequest } from '../Models/add-category-request.model';
import { CategoryService } from '../services/category.service';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-add-category',
  templateUrl: './add-category.component.html',
  styleUrls: ['./add-category.component.css']
})
export class AddCategoryComponent  implements OnDestroy{

  model: AddCategoryRequest;
  private addCatehgorySubscriptions?:Subscription;
  constructor(private categoryService:CategoryService){
    this.model={
      name:'',
      urlHandle:''
    }
  }
  onFormSubmit(){
this.addCatehgorySubscriptions=this.categoryService.addCategory(this.model)
.subscribe({
  next:(response)=>{
    console.log("this was succesful");
  }
})
  }
  ngOnDestroy(): void {
this.addCatehgorySubscriptions?.unsubscribe() 
 }


}
