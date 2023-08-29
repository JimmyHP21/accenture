import { createWebHistory, createRouter } from "vue-router";

import RegisterVue from "../views/Register.vue";
import HomeVue from "../views/Home.vue";



const router = createRouter({
  history: createWebHistory(),
  routes: [
    {
      path: '/',
      name: 'Home',
      component: HomeVue
    },
    {
      path: '/new',
      name: 'Cadastro',
      component: RegisterVue,
      props: true
    },
  ]
})

export default router;