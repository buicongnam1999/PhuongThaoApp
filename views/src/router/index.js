import Vue from 'vue'
import VueRouter from 'vue-router'

Vue.use(VueRouter)

const routes = [
    {
        path: "/",
        name: "home",
        component: ()=>
          import(/* */"../container/HomeContainer.vue"),
        
        children:[
            {
                path: "/blog",
                name: "Blog",
                component: () =>
                  import(/* webpackChunkName: "Blog" */ "../views/blog/BlogView.vue")
            },
            {
                path: "/cart",
                name: "Cart",
                component: () =>
                  import(/* webpackChunkName: "Cart" */ "../views/cart/CartView.vue")
            },
            {
                path: "/",
                name: "Home",
                component: () =>
                  import(/* webpackChunkName: "Home" */ "../views/home/HomeView.vue")
            },
        ]
    },
]

const router = new VueRouter({
  mode: 'history',
  base: process.env.BASE_URL,
  routes
})

export default router
