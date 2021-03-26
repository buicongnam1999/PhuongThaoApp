<template>
    <div class="button-basic">
        <slot></slot>
    </div>
</template>
<script>
export default {
    
}
</script>
<style scoped>
.button-basic{
    cursor: pointer;
    font-size: 16px;
    font-family: -apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Open Sans', 'Helvetica Neue', sans-serif;
}
.button-basic:hover{
    color: red;
    opacity: 0.8;
}
.button-basic i{
    font-size: 15px;
    margin-right: 10px;
}
</style>