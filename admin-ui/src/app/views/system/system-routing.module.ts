import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { UserComponent } from './users/user.component';
import { RoleComponent } from './roles/role.component';
import { AuthGuard } from 'src/app/shared/auth.guard';

const routes: Routes = [
  {
    path: '',
    redirectTo: 'users',
    pathMatch: 'full'
  },
  {
    path: 'users',
    component: UserComponent,
    canActivate: [AuthGuard],
    data: {
      title: 'Người dùng',
      requiredPolicy: 'Permissions.Users.View'
    }
  },
  {
    path: 'roles',
    component: RoleComponent,
    canActivate: [AuthGuard],
    data: {
      title: 'Quyền',
      requiredPolicy: 'Permissions.Users.View'
    }
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class SystemRoutingModule {
}
