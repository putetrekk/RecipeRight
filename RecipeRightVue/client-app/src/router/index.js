import { createRouter, createWebHistory } from 'vue-router';
import Home from '../views/Home.vue';
import About from '../views/About.vue';
import Ingredients from '../views/Ingredients.vue';

export const routes = [
  {
    name: 'Home',
    path: '/',
    component: Home
  },
  {
    name: 'Ingredients',
    path: '/ingredients',
    component: Ingredients
  },
  {
    name: 'About',
    path: '/about',
    component: About
  }
];

const router = createRouter({
  history: createWebHistory(),
  routes: routes
});

export default router;
