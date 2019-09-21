import { Component, OnInit, ViewEncapsulation  } from '@angular/core';
import { FormGroup, Validators, FormBuilder } from '@angular/forms';
import { dateValidator } from '../dateValidator';
import { PremiumCalc } from '../../models/premiumcalc';
import { Http } from '@angular/http';
                                          
const DATE_REGEX = new RegExp(/^(\d{2}|\d)\/(\d{2}|\d)\/\d{4}$/);

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  encapsulation: ViewEncapsulation.None
})
export class HomeComponent implements OnInit {
  // The occupation list will come from the database thru a service call.
  occupationsList: any[] = [{
    factor:"1.50",
    occupationName:"Cleaner"
  },
    {
      factor: "1.0",
      occupationName: "Doctor"
    },
    {
      factor: "1.25",
      occupationName: "Author"
    },
    {
      factor: "1.75",
      occupationName: "Farmer"
    },
    {
      factor: "1.75",
      occupationName: "Mechanic"
    },
    {
      factor: "1.50",
      occupationName: "Florist"
    }
      ]
    
  constructor(private formBuilder: FormBuilder) { }
  occupationList: any = ['Cleaner', 'Doctor', 'Author'];
  numbers : any= [45, 46, 47];
  premiumCalc: PremiumCalc;
  registerForm: FormGroup;
  premiumAmount: number;
  submitted = false;
  ngOnInit() {
    this.registerForm = this.formBuilder.group({
      insuredName: ['', Validators.required],
      age: ['', [Validators.required, Validators.min(0), Validators.max(150)]],
      dateOfBirth: ['', [Validators.required, Validators.maxLength(10), Validators.pattern(DATE_REGEX),dateValidator()]],
      sumInsured: ['', [Validators.required, Validators.min(0), Validators.max(10000000000)]],
     
    });
  }
   isFieldValid(field: string) {
    if (this.submitted) {
      return !this.registerForm.get(field).valid;
    }
    return !this.registerForm.get(field).valid && this.registerForm.get(field).touched;
  }

  calculatePremium(filterVal: any) {
     this.submitted = true;
    if (this.registerForm.valid) {
      this.premiumCalc = this.registerForm.value;
      this.premiumAmount = (this.premiumCalc.sumInsured * filterVal * this.premiumCalc.age) / 1000 * 12;
      this.premiumAmount = Math.round(this.premiumAmount);
    

  }
 
   
  }
}
