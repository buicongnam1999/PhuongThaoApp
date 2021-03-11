import Vue from 'vue'
import VueRouter from 'vue-router'

Vue.use(VueRouter)

const routes = [
  {
    path: "/",
    name: "home",
    component: ()=>
      import(/* */"../views/HomeView.vue")
    
  },
  {
    path:"/shopview",
    name: "Shop",
    component: ()=>
      import(/*Shop View */"../views/ShopView.vue")
    
  },
  {
    path: "/shoplogin",
    name: "login",
    component: ()=>
      import(/*Shop login */ "../views/ShopLogin.vue")
    
  }
]

const router = new VueRouter({
  mode: 'history',
  base: process.env.BASE_URL,
  routes
})

export default router
