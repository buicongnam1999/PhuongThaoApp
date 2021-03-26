import Vue from 'vue'
import VueRouter from 'vue-router'

Vue.use(VueRouter)

const routes = [
  {
    path: "/",
    name: "Home"
  },
  {
    path:"/employee",
    name: "Employee",
    component: ()=>
      import(/* Employee*/"../views/employee/EmployeeList.vue")
  }
  ,
  {
    path:"/customer",
    name: "Customer",
    component: ()=>
      import(/* Customer*/"../views/customer/CustomerList.vue")
  },
  {
    path: "/coupons",
    name: "Coupons",
    component: ()=>
      import(/* Coupons*/"../views/coupons/CouponsList.vue")
  },
  {
    path: "/account",
    name: "Account",
    component: ()=>
      import(/* Account*/"../views/account/AccountList.vue")
  },
  {
    path: "/order",
    name: "Order",
    component: ()=>
      import(/* Order*/"../views/order/OrderList.vue")
  }
  ,
  {
    path: "/product",
    name: "Product",
    component: ()=>
      import(/* Product*/"../views/product/ProductList.vue")
  },
  {
    path: "/login",
    name: "Login",
    component: () => 
      import(/*Login*/"../views/login/LoginForm.vue")
  }
]

const router = new VueRouter({
  mode: 'history',
  base: process.env.BASE_URL,
  routes
})

export default router
