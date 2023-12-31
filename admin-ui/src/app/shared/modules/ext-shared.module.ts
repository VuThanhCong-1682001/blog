import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { PermissionDirective } from './permission.directive';
import { ValidationMessageComponent } from './validation-message/validation-message.component';

@NgModule({
  imports: [CommonModule],
  declarations: [ValidationMessageComponent, PermissionDirective],
  exports: [ValidationMessageComponent],
})
export class ExtSharedModule {}