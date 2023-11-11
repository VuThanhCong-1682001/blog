import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AuthGuard } from 'src/app/shared/auth.guard';
import { PostCategoryComponent } from './post-categories/post-category.component';
import { PostComponent } from './posts/post.component';

const routes: Routes = [
  {
    path: '',
    redirectTo: 'posts',
    pathMatch: 'full',
  },
  {
    path: 'posts',
    component: PostComponent,
    canActivate: [AuthGuard],
    data: {
      title: 'Bài viết',
      requiredPolicy: 'Permissions.Posts.View',
    },
  },
  {
    path: 'post-categories',
    component: PostCategoryComponent,
    data: {
      title: 'Danh mục',
      requiredPolicy: 'Permissions.PostCategories.View',
    },
    canActivate: [AuthGuard],
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class ContentRoutingModule {}
