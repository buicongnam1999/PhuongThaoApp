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
                path: "/",
                name: "Home",
                component: () =>
                  import(/* webpackChunkName: "Home" */ "../views/home/HomeView.vue")
            },
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
              path: "/login",
              name: "Login",
              component: () =>
                import(/* webpackChunkName: "Login" */ "../views/login/LoginView.vue")
            },
            {
              path: "/register",
              name: "Register",
              component: () =>
                import(/* webpackChunkName: "Register" */ "../views/register/RegisterView.vue")
            },
            {
              path: "/shop",
              name: "Shop",
              component: () =>
                import(/* webpackChunkName: "Shop" */ "../views/shop/ShopView.vue")
            },
        ]
    },
    {
      path: "/admin",
      name: "Admin",
      component: ()=>
        import(/* */"../admin/container/AdminContainer.vue"),
      children:[
        {
          path: "/",
          name: "Login",
          component: () =>
            import(/* webpackChunkName: "Account" */ "../admin/views/login/LoginForm.vue")
        },
        {
          path: "/page",
          name: "Page",
          component: () =>
            import(/* webpackChunkName: "Account" */ "../admin/views/login/LoginForm.vue")
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
