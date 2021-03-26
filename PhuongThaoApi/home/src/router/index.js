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
      import(/*Shop login */ "../views/LoginView.vue")
    
  },
  {
    path: "/blog",
    name: "blog",
    component: ()=>
    import(/*Blog */ "../views/BlogView.vue")
  },
  {
    path: "/cart",
    name: "cart",
    component: ()=>
    import(
      /*Cart */ "../views/CartView.vue"
    )
  },
  {
    path: "/register",
    name: "register",
    component: ()=>
    import(
      /*Register */ "../views/RegisterView.vue"
    )
  },
  {
    path: "/login",
    name: "login",
    component: ()=>
    import(
      /*Login */ "../views/LoginView.vue"
    )
  },
  {
    path: "/order",
    name: "order",
    component: ()=>
    import(
      /*Order */ "../views/OrderView.vue"
    )
  },
]

const router = new VueRouter({
  mode: 'history',
  base: process.env.BASE_URL,
  routes
})

export default router
