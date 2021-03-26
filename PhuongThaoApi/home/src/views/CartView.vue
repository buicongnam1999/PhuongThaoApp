<template>
    <div class="cart">
        <div>
            <h1>Giỏ hàng</h1>
        </div>
        <cart-grid />
    </div>
</template>

<script>
import CartGrid from '../components/cart/CartGrid.vue'
export default {
  components: { 
    CartGrid 
  },
    
}
</script>

<style scoped>
.cart{
  margin-top: 50px;
}
h1{
  text-align: center;
}
</style>